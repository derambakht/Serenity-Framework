import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProvincesForm, ProvincesRow, ProvincesService } from '../../ServerTypes/Behsa';

@Decorators.registerClass('BehsaApp.Behsa.ProvincesDialog')
export class ProvincesDialog extends EntityDialog<ProvincesRow, any> {
    protected getFormKey() { return ProvincesForm.formKey; }
    protected getRowDefinition() { return ProvincesRow; }
    protected getService() { return ProvincesService.baseUrl; }

    protected form = new ProvincesForm(this.idPrefix);
}