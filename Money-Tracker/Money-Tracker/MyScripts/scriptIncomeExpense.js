$(document).ready(function () {
    var userID = $.session.get('userID');

    if (typeof userID == 'undefined' || userID=="null") {
        window.location.replace("Home.aspx");
        return;
    }

    // Bind the drop downs
    ajaxCaller("Helper.asmx/GetBalance","{intId:"+userID+"}", SuccessBal, FailureCall);
    ajaxCaller("Helper.asmx/GetAllIncome", "{}", SuccessCall, FailureCall);
    ajaxCaller("Helper.asmx/GetAllExpense", "{}", SuccessCallExp, FailureCall);
    
    $("#btn_addIncome").click(function () {
        var incAmount = $('#txt_amtIncome').val()
        if ($.isNumeric(incAmount) && incAmount!=0.00) {
            insertIncome(userID);
            ajaxCaller("Helper.asmx/GetBalance", "{intId:" + userID + "}", SuccessBal, FailureCall);
        } else {
            ShowNotification('<p>Enter correct amount.</p>');
        }
    });

    $("#btn_addExpense").click(function () {
        insertExpense(userID);
        ajaxCaller("Helper.asmx/GetBalance", "{intId:" + userID + "}", SuccessBal, FailureCall);
    });

    $("#btn_export").click(function () {
        ajaxCaller("Helper.asmx/ExportToXL", "{intId:" + userID + "}", FailureCall);
    });
});

// GENERIC AJAX CALL
function ajaxCaller(url, dataToSend, SuccessCallBack, FailureCallBack) {
    $.ajax({
        url: url,
        async: true,
        type: 'POST',
        data: dataToSend,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: SuccessCallBack,
        error: FailureCallBack
    });
}

function FailureCall(xhr, msg, exception) {
   // alert(msg);
}

function SuccessBal(data)
{
    $("#lblBalance").text(data.d);
}

function ShowNotification() {
    var notification = new NotificationFx({
        wrapper: document.body,
        message: '<p>Your entry have been saved successfully.You can view on calendar.</p>',
        layout: 'growl',
        effect: 'bouncy',
        type: 'notice',
        ttl: 6000,
        onClose: function () { return false; },
        onOpen: function () { return false; }
    });
    notification.show();
}

// To generate noty messages
function ShowMessage() {
    var n = noty({
        text: 'Your data have been saved successfully.',
        type: 'information',
        timeout: 3000,
    })
}

function BindDropDown(selector, data, dataMember, valueMember) {
    for (var obj in data) {
        $(selector).append("<option value=" + data[obj][valueMember] + ">" + data[obj][dataMember] + "</option>")
    }
    $(selector).selectOrDie("update");
}

function SuccessCall(data) {
    var Type = data.d;
    BindDropDown("#ddlIncCategory", Type, "Name", "Id");
}

function SuccessCallExp(data) {
    var Type = data.d;
    BindDropDown("#ddlExpCategory", Type, "Name", "Id");
}

// Enter income data to databse
function insertIncome(userID) {
    var Income = JSON.stringify({ "objIncome": [userID, $("#txt_amtIncome").val(), $("#txt_amtExpense").val(), $("#ddlIncCategory option:selected").val(), $("#txt_noteIncome").val()] });
    ajaxCaller("Helper.asmx/InsertIncome", Income, ShowMessage, FailureCall);
    return false;
}

function insertExpense(userID) {
    var Expense = JSON.stringify({ "objIncome": [userID, $("#txt_amtIncome").val(), $("#txt_amtExpense").val(), $("#ddlExpCategory option:selected").val(), $("#txt_noteExpense").val()] });
    ajaxCaller("Helper.asmx/InsertIncome", Expense, ShowMessage, FailureCall);
    return false;
}

function SuccessCallInc() {
    //alert("Ok");
    $(".manageContainer")[0].reset();
    $(".manageContainer")[1].reset();
}

function ResetIncomeExpense() {
    $('#txt_amtIncome').val('0.00');
    $("#txt_noteIncome").val('Type here');
    $('#txt_amtIncome').val('0.00');
    $("#txt_noteIncome").val('Type here');
}
function SuccessBalance() {
    
}