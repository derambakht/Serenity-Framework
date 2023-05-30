import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { MembersForm, MembersRow, MembersService } from '../../ServerTypes/Behsa';

@Decorators.registerClass('BehsaApp.Behsa.MembersDialog')
export class MembersDialog extends EntityDialog<MembersRow, any> {
    protected getFormKey() { return MembersForm.formKey; }
    protected getRowDefinition() { return MembersRow; }
    protected getService() { return MembersService.baseUrl; }

    protected form = new MembersForm(this.idPrefix);
}