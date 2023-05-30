import { ServiceRequest, ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";
import { MemberDto } from "./Modules.Support.About.MemberDto";

export namespace AboutService {
    export const baseUrl = 'Support/About';

    export declare function GetMembers(request: ServiceRequest, onSuccess?: (response: MemberDto[]) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        GetMembers: "Support/About/GetMembers"
    } as const;

    [
        'GetMembers'
    ].forEach(x => {
        (<any>AboutService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}