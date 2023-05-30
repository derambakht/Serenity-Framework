import { fieldsProxy } from "@serenity-is/corelib/q";

export interface UsersRow {
    Id?: string;
    FirstName?: string;
    LastName?: string;
    UserName?: string;
    Password?: string;
    Salt?: string;
}

export abstract class UsersRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'FirstName';
    static readonly localTextPrefix = 'Behsa.Users';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<UsersRow>();
}