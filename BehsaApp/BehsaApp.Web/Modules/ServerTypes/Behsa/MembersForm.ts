import { StringEditor, DateEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface MembersForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    BirthDate: DateEditor;
    ProvinceId: LookupEditor;
    CityId: LookupEditor;
}

export class MembersForm extends PrefixedContext {
    static formKey = 'Behsa.Members';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MembersForm.init)  {
            MembersForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = LookupEditor;

            initFormType(MembersForm, [
                'FirstName', w0,
                'LastName', w0,
                'BirthDate', w1,
                'ProvinceId', w2,
                'CityId', w2
            ]);
        }
    }
}