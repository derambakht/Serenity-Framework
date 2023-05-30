import { DateEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface FinancialRowsForm {
    ChangeDate: DateEditor;
    Amount: StringEditor;
}

export class FinancialRowsForm extends PrefixedContext {
    static formKey = 'Behsa.FinancialRows';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!FinancialRowsForm.init)  {
            FinancialRowsForm.init = true;

            var w0 = DateEditor;
            var w1 = StringEditor;

            initFormType(FinancialRowsForm, [
                'ChangeDate', w0,
                'Amount', w1
            ]);
        }
    }
}