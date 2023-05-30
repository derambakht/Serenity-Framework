import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EmployeesRow {
    Id?: number;
    NationalCode?: string;
    FirstName?: string;
    LastName?: string;
    BirthDate?: string;
}

export abstract class EmployeesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'NationalCode';
    static readonly localTextPrefix = 'Behsa.Employees';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EmployeesRow>();
}