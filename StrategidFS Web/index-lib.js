import { accountInfo, usd, pct } from './global.js';


// Assumptions:
//  1. The DOM will not be manipulated outside of the script in this file therefore
//      the summary and total rows do not need to hook into DOM changes on the table
//  2. The fomatting in the example is not precise for the units of money amounts, USD is used.
//  3. Inserted and deleted rows will not be stored persistently. A page reload will start over.
//  4. The code will value simplicity over elegance.

export function loadDisplayRow(item, isChecked) {

    // Requirement: insert a row into the target HTML table loaded with
    // the values from the item object

    // item object =
    //{
    //    "id": 8,
    //    "creditorName": "CAPITAL ONE",
    //    "firstName": "Suman",
    //    "lastName": "Tester79",
    //    "minPaymentPercentage": 4.00,
    //    "balance": 836.00
    //}

    // Locate the template in the DOM (it's a hidden table row)
    // Clone it
    // Set the text of the td's within the cloned table row to match the item's values
    // Insert the cloned row at the end of the data rows in the table
    //  * there are command, summary, and total rows in the table, so make
    //  sure to get in front of those.

    // Locate the template for the rows and clone it
    var templateRow = $('#rowTemplate > table > tbody > tr');
    var templateRowClone = templateRow.clone();

    // Assign values from the json to the table cells
    var $checkbox = templateRowClone.children('td[name="id"]').children('input[type="checkbox"]');
    $checkbox.attr('data-id', item.id);
    $checkbox.prop('checked', isChecked);

    isChecked
    templateRowClone.children('td[name="creditorName"]').text(item.creditorName);
    templateRowClone.children('td[name="firstName"]').text(item.firstName);
    templateRowClone.children('td[name="lastName"]').text(item.lastName);
    templateRowClone.children('td[name="minPaymentPercentage"]').text(pct.format(item.minPaymentPercentage / 100.0));

    // Note: displaying the balance as USD is outside of the spec, but it seems like a logical thing to do
    templateRowClone.children('td[name="balance"]').text(usd.format(item.balance));

    // Set an event for the checkbox to change the background color of the row
    templateRowClone.children('td[name="id"]').children('input[type="checkbox"]').change(function () {
        var $checkbox = $(this);
        var isChecked = $checkbox[0].checked;

        updateCheckedDisplayForTableRow($checkbox, isChecked);
        updateTotals();
    });


    // Put the row just before the controls at the bottom of the table
    var target = $('#controlRow');
    templateRowClone.insertBefore(target);
    updateTotals();
};

export function updateCheckboxDisplayForTable() {
    var $checkboxes = $('tbody#accountInfoTable-tbody').find('input:checkbox');

    // After toggling all of the checkboxes, now set the display (background color)
    // for each one.
    for (var i = 0; i < $checkboxes.length; i++) {
        updateCheckedDisplayForTableRow($checkboxes[i], $checkboxes[i].checked);
    }
}

// Referencing the passed checkbox input element, set the class of every td in the row
function updateCheckedDisplayForTableRow(checkbox, isChecked) {
    var tableCells = Enumerable.from($(checkbox).parent().siblings());

    tableCells.forEach(function (cell) {
        if (isChecked == true) {
            $(cell).removeClass("unselected-row");
        }
        else {
            $(cell).addClass("unselected-row");
        }
    });
}

var clearTableDataRows = function () {
    $('#controlRow').prevAll().remove();
}

export function loadTable(items, isChecked) {
    clearTableDataRows();
    items.forEach(function (i) {
        loadDisplayRow(i, isChecked);
    });
    // Whenever the entire table is loaded, make sure the select-all is toggled appropriately
    $('#select_all').prop('checked', isChecked)
};


export function removeItems(items, idsToRemove) {
    var idsEnum = Enumerable.from(idsToRemove);
    for (var i = 0; i < items.length; i++) {
        if (idsEnum.contains(items[i].id)) {
            items.splice(i, 1);
            i--;
        }
    }
}

export function updateTotals() {
    var itemsEnum = Enumerable.from(accountInfo);
    var totalRowCount = itemsEnum.count();
    var totalBalance = itemsEnum.sum(item => item.balance);

    // To get the rows that are checked, we have to look at the DOM and not the data
    // And make sure to exclude the select-all checkbox
    var $dataCheckboxCells = $('td[name=id]');
    var totalCheckedRowCount = $dataCheckboxCells.children('input:checked').length-1;

    $('#totalBalance').text(usd.format(totalBalance));
    $('#totalRowCount').text("Total Row Count: " + totalRowCount);
    $('#totalCheckedCount').text("Check Row Count: " + totalCheckedRowCount);
};

