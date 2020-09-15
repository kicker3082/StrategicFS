import { accountInfo, url } from './global.js';
import { loadTable, loadDisplayRow, removeItems, updateCheckboxDisplayForTable, updateTotals } from './index-lib.js'


$(function () {
    // Load data via AJAX

    $.ajax({
        url: url,
        data: null,
        success: function (data, status, jqXHR) {
            // Stuff table rows here
            accountInfo.length = 0;
            for (var i = 0; i < data.length; i++) {
                accountInfo.push(data[i]);
            }
            loadTable(accountInfo, true);
        },
        dataType: "json"
    });

    // Have the header checkbox set all checkboxes to its value
    $('#select_all').change(function () {
        var isChecked = $(this)[0].checked;
        var $checkboxes = $('tbody#accountInfoTable-tbody').find('input:checkbox');
        $checkboxes.prop('checked', isChecked);

        // After toggling all of the checkboxes, now set the display (background color)
        // for everthing.
        updateCheckboxDisplayForTable();
        // Reflect the checked/unchecked count
        updateTotals();
    });

    // Set the Add Debt button to add a row to the table
    $('#addButton').click(function () {
        var maxId = accountInfo.length > 0 ? Enumerable.from(accountInfo).select(i => i.id).max() : -1;
        var newItem = {
            id: ++maxId,
            creditorName: "new Creditor",
            firstName: "First",
            lastName: "Last",
            minPaymentPercentage: 2.5,
            balance: 8776.00
        };
        accountInfo.push(newItem);

        loadDisplayRow(newItem, true);

    });

    // Set the Remove button to remove the checked rows from the table
    $('#removeButton').click(function () {
        var checked = $('tbody#accountInfoTable-tbody').find('input[type="checkbox"]:checked')
        var idsToDelete = checked.map(function () {
            return $(this).data('id');
        }).get();
        removeItems(accountInfo, idsToDelete);
        // By definition, after removing all checked rows, the remaining rows are all unchecked
        // so when re-loading them from the source, display them as unchecked
        loadTable(accountInfo, false);
        updateCheckboxDisplayForTable();
    });
});
