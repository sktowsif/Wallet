$(document).ready(function() {
    
    //populate the country drop down list
    ajaxCall('Registration.aspx/FillCountryDropDown', '{}', BindCountry, ErrorCallBack);

    // button register action
    $('#btn_register').click(function () {
        Validations();
    });
})

// Ajax Call 
function ajaxCall(url, dataToSend, SuccessCallBack, ErrorCallBack) {
    $.ajax({
        url: url,
        async: true,
        type: 'POST',
        data: dataToSend,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: SuccessCallBack,
        error: ErrorCallBack
    });
}
function ShowMessage(msg, type) {
    var n = noty({
        text: msg,
        type: type,
        timeout: 3000,
    })
}
function Validations() {
    var checkValidation = true;
    var email = $('#txt_email').val();
    var pwd = $('#txt_pwd').val();
    var conPwd = $('#txt_conpwd').val();
    var name = $("#txt_name").val();
    var male = $("#rdoMale").val();
    var female = $("#rdoFemale").val();

    if ($.trim(name).length == 0)
    {
        ShowMessage('Please Enter your Name', 'error');
        checkValidation = false;
        return;
    }
    if ($.trim(email).length == 0)
    {
        ShowMessage('Please Enter your Email', 'error');
        checkValidation = false;
        return;
    }
    if ($.trim(pwd).length == 0) {
        ShowMessage('Please Enter Password', 'error');
        checkValidation = false;
        return;
    }
    if ($.trim(pwd)!=$.trim(conPwd)) {
        ShowMessage('Password and Conform Password must Match', 'error');
        checkValidation = false;
        return;
    }
    if ($('input[name=gender]:checked').length <= 0) {
        ShowMessage('Please Select Gender', 'error');
        checkValidation = false;
        return;
    }
    if ($("#ddlCountry").val() == -1)
    {
        ShowMessage('Please Select Country', 'error');
        checkValidation = false;
        return;
    }
    if (checkValidation)
        GetUserDetails();
};
// Called when error is encountered by ajax call
function ErrorCallBack(xhr,msg,exception) {
    alert(msg);
}

// create the option attribute for drop down
function BindDropDown(selector,data,dataMember,valueMember) {
    for (var obj in data) 
        $(selector).append("<option value=" + data[obj][valueMember] + ">" + data[obj][dataMember] + "</option>")
}

// get the value on success call
function BindCountry(data) {
    var country = data.d;
    BindDropDown('#ddlCountry',country,"Name","Id");
}

// get the user data from registration form
// and store in database using ajax
function GetUserDetails() {
    var name = $('#txt_name').val();
    var email = $('#txt_email').val();
    var pwd = $('#txt_pwd').val();

    // read the gender selected
    var gender = $('input[name=gender]:checked', '#formRegister').val();

    // find the country selected
    var $selectedOpt = $('#ddlCountry').find('option:selected');
    var country = $selectedOpt.text();
    
    var objUserData = JSON.stringify({"objUserData":[name,gender,email,pwd,country] });

    ajaxCall('Registration.aspx/InsertUser', objUserData, SuccessUserInsert, ErrorCallBack);
}

function SuccessUserInsert() {
    var n = noty({
        text: 'You are successfully signed up go back to login page!',
        type: 'information',
        theme: 'defaultTheme'
    });
}