import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CitiesForm {
    CityName: StringEditor;
    ProvinceId: LookupEditor;
}

export class CitiesForm extends PrefixedContext {
    static formKey = 'Behsa.Cities';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CitiesForm.init)  {
            CitiesForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CitiesForm, [
                'CityName', w0,
                'ProvinceId', w1
            ]);
        }
    }
}