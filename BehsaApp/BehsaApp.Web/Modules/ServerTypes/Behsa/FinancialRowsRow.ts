import { fieldsProxy } from "@serenity-is/corelib/q";

export interface FinancialRowsRow {
    Id?: number;
    ChangeDate?: string;
    Amount?: number;
}

export abstract class FinancialRowsRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Behsa.FinancialRows';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<FinancialRowsRow>();
}