import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { UsersForm, UsersRow, UsersService } from '../../ServerTypes/Behsa';

@Decorators.registerClass('BehsaApp.Behsa.UsersDialog')
export class UsersDialog extends EntityDialog<UsersRow, any> {
    protected getFormKey() { return UsersForm.formKey; }
    protected getRowDefinition() { return UsersRow; }
    protected getService() { return UsersService.baseUrl; }

    protected form = new UsersForm(this.idPrefix);
}