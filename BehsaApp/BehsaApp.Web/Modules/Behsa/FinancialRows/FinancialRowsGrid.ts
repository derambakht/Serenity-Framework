import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { FinancialRowsColumns, FinancialRowsRow, FinancialRowsService } from '../../ServerTypes/Behsa';
import { FinancialRowsDialog } from './FinancialRowsDialog';

@Decorators.registerClass('BehsaApp.Behsa.FinancialRowsGrid')
export class FinancialRowsGrid extends EntityGrid<FinancialRowsRow, any> {
    protected getColumnsKey() { return FinancialRowsColumns.columnsKey; }
    protected getDialogType() { return FinancialRowsDialog; }
    protected getRowDefinition() { return FinancialRowsRow; }
    protected getService() { return FinancialRowsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}