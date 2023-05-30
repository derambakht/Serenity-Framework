import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProvincesColumns, ProvincesRow, ProvincesService } from '../../ServerTypes/Behsa';
import { ProvincesDialog } from './ProvincesDialog';

@Decorators.registerClass('BehsaApp.Behsa.ProvincesGrid')
export class ProvincesGrid extends EntityGrid<ProvincesRow, any> {
    protected getColumnsKey() { return ProvincesColumns.columnsKey; }
    protected getDialogType() { return ProvincesDialog; }
    protected getRowDefinition() { return ProvincesRow; }
    protected getService() { return ProvincesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}