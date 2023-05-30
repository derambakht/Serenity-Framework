import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface CitiesRow {
    Id?: number;
    CityName?: string;
    ProvinceId?: number;
    ProvinceName?: string;
}

export abstract class CitiesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'CityName';
    static readonly localTextPrefix = 'Behsa.Cities';
    static readonly lookupKey = 'Behsa.Cities';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CitiesRow>('Behsa.Cities') }
    static async getLookupAsync() { return getLookupAsync<CitiesRow>('Behsa.Cities') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<CitiesRow>();
}