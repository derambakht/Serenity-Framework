import { fieldsProxy } from "@serenity-is/corelib/q";

export interface MembersRow {
    Id?: number;
    FirstName?: string;
    LastName?: string;
    BirthDate?: string;
    CityId?: number;
    CityName?: string;
    ProvinceId?: number;
}

export abstract class MembersRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'FirstName';
    static readonly localTextPrefix = 'Behsa.Members';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MembersRow>();
}