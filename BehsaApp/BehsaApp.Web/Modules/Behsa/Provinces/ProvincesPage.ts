import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProvincesGrid } from './ProvincesGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProvincesGrid($('#GridDiv')).element);
}