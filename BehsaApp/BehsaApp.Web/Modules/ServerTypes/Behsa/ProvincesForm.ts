import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProvincesForm {
    ProvinceName: StringEditor;
}

export class ProvincesForm extends PrefixedContext {
    static formKey = 'Behsa.Provinces';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProvincesForm.init)  {
            ProvincesForm.init = true;

            var w0 = StringEditor;

            initFormType(ProvincesForm, [
                'ProvinceName', w0
            ]);
        }
    }
}