import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EmployeesColumns, EmployeesRow, EmployeesService } from '../../ServerTypes/Behsa';
import { EmployeesDialog } from './EmployeesDialog';

@Decorators.registerClass('BehsaApp.Behsa.EmployeesGrid')
export class EmployeesGrid extends EntityGrid<EmployeesRow, any> {
    protected getColumnsKey() { return EmployeesColumns.columnsKey; }
    protected getDialogType() { return EmployeesDialog; }
    protected getRowDefinition() { return EmployeesRow; }
    protected getService() { return EmployeesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}