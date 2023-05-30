import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface ProvincesRow {
    Id?: number;
    ProvinceName?: string;
}

export abstract class ProvincesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'ProvinceName';
    static readonly localTextPrefix = 'Behsa.Provinces';
    static readonly lookupKey = 'Behsa.Provinces';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ProvincesRow>('Behsa.Provinces') }
    static async getLookupAsync() { return getLookupAsync<ProvincesRow>('Behsa.Provinces') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProvincesRow>();
}