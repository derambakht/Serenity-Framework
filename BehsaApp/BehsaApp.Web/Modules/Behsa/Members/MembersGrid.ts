import { Decorators, EntityGrid, LookupEditor } from "@serenity-is/corelib";
import { deepClone, Dictionary, first, formatNumber, htmlEncode, notifyError, parseDecimal, parseInteger, parseQueryString, serviceRequest, localText, toId, trimToNull, tryFirst, Lookup } from "@serenity-is/corelib/q";
import { ExcelExportHelper, PdfExportHelper } from "@serenity-is/extensions";
import { Column, FormatterContext, NonDataRow } from "@serenity-is/sleekgrid";
import { CitiesRow, MembersColumns, MembersRow, MembersService } from '../../ServerTypes/Behsa';
import { MembersDialog } from './MembersDialog';

const fld = MembersRow.Fields;

@Decorators.registerClass('BehsaApp.Behsa.MembersGrid')
export class MembersGrid extends EntityGrid<MembersRow, any> {
    protected getColumnsKey() { return MembersColumns.columnsKey; }
    protected getDialogType() { return MembersDialog; }
    protected getRowDefinition() { return MembersRow; }
    protected getService() { return MembersService.baseUrl; } 

    private pendingChanges: Dictionary<any> = {};

    constructor(container: JQuery) {
        super(container);

        this.slickContainer.on('change', '.edit:input', (e) => this.inputsChange(e));
    }

    protected getButtons() {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: MembersService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push({
            title: 'Save Changes',
            cssClass: 'apply-changes-button disabled',
            onClick: e => this.saveClick(),
            separator: true
        });

        buttons.push({
            title: 'Download PDF',
            onClick: e => alert("download pdf"),
            separator: true
        });

        return buttons;
    }

    protected onViewProcessData(response) {
        this.pendingChanges = {};
        this.setSaveButtonState();
        return super.onViewProcessData(response);
    }

    private numericInputFormatter(ctx) {
        if ((ctx.item as NonDataRow).__nonDataRow)
            return htmlEncode(formatNumber(ctx.value, '#0.##'));

        var klass = 'edit numeric';
        var item = ctx.item as MembersRow;
        var pending = this.pendingChanges[item.Id];

        if (pending && pending[ctx.column.field] !== undefined) {
            klass += ' dirty';
        }

        var value = this.getEffectiveValue(item, ctx.column.field) as number;

        return "<input type='text' class='" + klass +
            "' data-field='" + ctx.column.field +
            "' value='" + formatNumber(value, '0.##') + "'/>";
    }

    private stringInputFormatter(ctx) {
        if ((ctx.item as NonDataRow).__nonDataRow)
            return htmlEncode(ctx.value);

        var klass = 'edit string';
        var item = ctx.item as MembersRow;
        var pending = this.pendingChanges[item.Id];
        var column = ctx.column as Column;

        if (pending && pending[column.field] !== undefined) {
            klass += ' dirty';
        }

        var value = this.getEffectiveValue(item, column.field) as string;

        return "<input type='text' class='" + klass +
            "' data-field='" + column.field +
            "' value='" + htmlEncode(value) +
            "' maxlength='" + column.sourceItem.maxLength + "'/>";
    }


    private selectFormatter(ctx: FormatterContext, idField: string, lookup: Lookup<any>) {
        if ((ctx.item as NonDataRow).__nonDataRow)
            return htmlEncode(ctx.value);

        var klass = 'edit';
        var item = ctx.item as MembersRow;
        var pending = this.pendingChanges[item.Id];
        var column = ctx.column as Column;

        if (pending && pending[idField] !== undefined) {
            klass += ' dirty';
        }

        var value = this.getEffectiveValue(item, idField);
        var markup = "<select class='" + klass +
            "' data-field='" + idField +
            "' style='width: 100%; max-width: 100%'>" +
            "<option value=''>--</option>";
        for (var c of lookup.items) {
            let id = c[lookup.idField];
            markup += "<option value='" + htmlEncode(id) + "'"
            if (id == value) {
                markup += " selected";
            }
            markup += ">" + htmlEncode(c[lookup.textField]) + "</option>";
        }
        return markup + "</select>";
    }

    private getEffectiveValue(item, field): any {
        var pending = this.pendingChanges[item.Id];
        if (pending && pending[field] !== undefined) {
            return pending[field];
        }

        return item[field];
    }

    protected getColumns() {
        var columns = super.getColumns();
        var num = ctx => this.numericInputFormatter(ctx);
        var str = ctx => this.stringInputFormatter(ctx);

        first(columns, x => x.field === 'FirstName').format = str;

        var city = first(columns, x => x.field === fld.CityName);
        city.referencedFields = [fld.CityId];
        city.format = ctx => this.selectFormatter(ctx, fld.CityId, CitiesRow.getLookup());
        first(columns, x => x.field === fld.LastName).format = str;

        return columns;
    }

    private inputsChange(e: JQueryEventObject) {
        var cell = this.slickGrid.getCellFromEvent(e);
        var item = this.itemAt(cell.row);
        var input = $(e.target);
        var field = input.data('field');
        var txt = trimToNull(input.val());
        var pending = this.pendingChanges[item.Id];

        var effective = this.getEffectiveValue(item, field);
        var oldText: string;
        if (input.hasClass("numeric"))
            oldText = formatNumber(effective, '0.##');
        else
            oldText = effective as string;

        var value;
        if (field === 'FirstName') {
            value = txt;
            console.log("firstName value changed:", value)
        }
        else if (input.hasClass("numeric")) {
            var i = parseInteger(txt ?? '');
            if (isNaN(i) || i > 32767 || i < 0) {
                notifyError(localText('Validation.Integer'), '', null);
                input.val(oldText);
                input.focus();
                return;
            }
            value = i;
        }
        else if (input.is('select'))
            value = toId(input.val());
        else
            value = txt;

        if (!pending) {
            this.pendingChanges[item.Id] = pending = {};
        }

        pending[field] = value;
        item[field] = value;
        this.view.refresh();

        if (input.hasClass("numeric"))
            value = formatNumber(value, '0.##');

        input.val(value).addClass('dirty');

        this.setSaveButtonState();
    }

    private setSaveButtonState() {
        this.toolbar.findButton('apply-changes-button').toggleClass('disabled',
            Object.keys(this.pendingChanges).length === 0);
    }

    private saveClick() {
        if (Object.keys(this.pendingChanges).length === 0) {
            return;
        }

        // this calls save service for all modified rows, one by one
        // you could write a batch update service
        var keys = Object.keys(this.pendingChanges);
        var current = -1;
        var self = this;

        (function saveNext() {
            if (++current >= keys.length) {
                self.refresh();
                return;
            }

            var key = keys[current];
            var entity = deepClone(self.pendingChanges[key]);
            entity.Id = key;
            serviceRequest(MembersService.Methods.Update, {
                EntityId: key,
                Entity: entity
            }, (response) => {
                delete self.pendingChanges[key];
                saveNext();
            });
        })();
    }

    protected getQuickFilters() {
        var flt = super.getQuickFilters();

        var q = parseQueryString();
        if (q["city"]) {
            var city = tryFirst(flt, x => x.field == "CityId");
            city.init = e => {
                e.element.getWidget(LookupEditor).value = q["city"];
            };
        }

        return flt;
    }

}
