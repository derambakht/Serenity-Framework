import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UsersColumns, UsersRow, UsersService } from '../../ServerTypes/Behsa';
import { UsersDialog } from './UsersDialog';

@Decorators.registerClass('BehsaApp.Behsa.UsersGrid')
export class UsersGrid extends EntityGrid<UsersRow, any> {
    protected getColumnsKey() { return UsersColumns.columnsKey; }
    protected getDialogType() { return UsersDialog; }
    protected getRowDefinition() { return UsersRow; }
    protected getService() { return UsersService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}