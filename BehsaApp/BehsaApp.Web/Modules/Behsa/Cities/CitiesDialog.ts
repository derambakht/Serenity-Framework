import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CitiesForm, CitiesRow, CitiesService } from '../../ServerTypes/Behsa';

@Decorators.registerClass('BehsaApp.Behsa.CitiesDialog')
export class CitiesDialog extends EntityDialog<CitiesRow, any> {
    protected getFormKey() { return CitiesForm.formKey; }
    protected getRowDefinition() { return CitiesRow; }
    protected getService() { return CitiesService.baseUrl; }

    protected form = new CitiesForm(this.idPrefix);
}