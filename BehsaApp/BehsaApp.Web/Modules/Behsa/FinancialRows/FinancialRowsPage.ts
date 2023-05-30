import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { FinancialRowsGrid } from './FinancialRowsGrid';

export default function pageInit() {
    initFullHeightGridPage(new FinancialRowsGrid($('#GridDiv')).element);
}