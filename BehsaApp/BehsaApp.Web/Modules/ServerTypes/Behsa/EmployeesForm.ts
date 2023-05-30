import { StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EmployeesForm {
    NationalCode: StringEditor;
    FirstName: StringEditor;
    LastName: StringEditor;
    BirthDate: DateEditor;
}

export class EmployeesForm extends PrefixedContext {
    static formKey = 'Behsa.Employees';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EmployeesForm.init)  {
            EmployeesForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;

            initFormType(EmployeesForm, [
                'NationalCode', w0,
                'FirstName', w0,
                'LastName', w0,
                'BirthDate', w1
            ]);
        }
    }
}