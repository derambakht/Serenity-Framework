import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { FinancialRowsForm, FinancialRowsRow, FinancialRowsService } from '../../ServerTypes/Behsa';

@Decorators.registerClass('BehsaApp.Behsa.FinancialRowsDialog')
export class FinancialRowsDialog extends EntityDialog<FinancialRowsRow, any> {
    protected getFormKey() { return FinancialRowsForm.formKey; }
    protected getRowDefinition() { return FinancialRowsRow; }
    protected getService() { return FinancialRowsService.baseUrl; }

    protected form = new FinancialRowsForm(this.idPrefix);
}