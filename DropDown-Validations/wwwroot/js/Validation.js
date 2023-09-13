

function fnValidateMobileNo(data) {
    var regex = new RegExp("^([+][9][1][1][0]){0,1}([6-9]{1})([0-9]{9})$")
    return regex.test(data);
}

function validateEmail(email) {
    debugger;
    var ema = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})$/;
    return ema.test(email)
}