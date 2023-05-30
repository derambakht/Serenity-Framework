import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CitiesGrid } from './CitiesGrid';

export default function pageInit() {
    initFullHeightGridPage(new CitiesGrid($('#GridDiv')).element);
}