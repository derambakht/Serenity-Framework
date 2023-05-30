import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface UsersForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    UserName: StringEditor;
    Password: StringEditor;
    Salt: StringEditor;
}

export class UsersForm extends PrefixedContext {
    static formKey = 'Behsa.Users';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UsersForm.init)  {
            UsersForm.init = true;

            var w0 = StringEditor;

            initFormType(UsersForm, [
                'FirstName', w0,
                'LastName', w0,
                'UserName', w0,
                'Password', w0,
                'Salt', w0
            ]);
        }
    }
}