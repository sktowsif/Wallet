$(document).ready(function () {
    $('.panel-radios').hide();
    Waves.displayEffect();
    $('.styleSlider').ftext();
    $('.ddl').selectOrDie();

    $('#btn_logout').click(function () {
        var und;
        $.session.set('userID', "null");
        window.location.replace('Home.aspx');
    })
});

// BASIC AJAX CALL METHOD
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

// BASIC DROPDOWN BINDER METHOD
function BindDropDown(selector, data, dataMember, valueMember) {
    for (var obj in data) {
        $(selector).append("<option value=" + data[obj][valueMember] + ">" + data[obj][dataMember] + "</option>")
    }
    $(selector).selectOrDie("update");
}

// Show failure messages
function FailureCall(xhr, msg, exception) {
    alert(msg);
}

// On success ajax call bind the drop down data
function BindIncome(data) {
    var Type = data.d;
    BindDropDown("#ddlIncCategory", Type, "Name", "Id");
}
function BindExpense(data) {
    var Type = data.d;
    BindDropDown("#ddlExpCategory", Type, "Name", "Id");
}

