import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { MembersGrid } from './MembersGrid';

export default function pageInit() {
    initFullHeightGridPage(new MembersGrid($('#GridDiv')).element);
}