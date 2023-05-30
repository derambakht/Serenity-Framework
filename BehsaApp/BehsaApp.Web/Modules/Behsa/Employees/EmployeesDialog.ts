import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EmployeesForm, EmployeesRow, EmployeesService } from '../../ServerTypes/Behsa';

@Decorators.registerClass('BehsaApp.Behsa.EmployeesDialog')
export class EmployeesDialog extends EntityDialog<EmployeesRow, any> {
    protected getFormKey() { return EmployeesForm.formKey; }
    protected getRowDefinition() { return EmployeesRow; }
    protected getService() { return EmployeesService.baseUrl; }

    protected form = new EmployeesForm(this.idPrefix);
}