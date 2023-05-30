import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { UsersGrid } from './UsersGrid';

export default function pageInit() {
    initFullHeightGridPage(new UsersGrid($('#GridDiv')).element);
}