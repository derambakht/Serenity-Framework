import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CitiesColumns, CitiesRow, CitiesService } from '../../ServerTypes/Behsa';
import { CitiesDialog } from './CitiesDialog';

@Decorators.registerClass('BehsaApp.Behsa.CitiesGrid')
export class CitiesGrid extends EntityGrid<CitiesRow, any> {
    protected getColumnsKey() { return CitiesColumns.columnsKey; }
    protected getDialogType() { return CitiesDialog; }
    protected getRowDefinition() { return CitiesRow; }
    protected getService() { return CitiesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}