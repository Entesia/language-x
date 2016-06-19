function createCookie(name, value, days) {
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        var expires = "; expires=" + date.toGMTString();
    }
    else var expires = "";

    document.cookie = name + "=" + value + expires + "; path=/";
}

$(document).on('click', '.localization > a', function (e) {
    e.preventDefault();

    var culture = $(this).data('lang');
    createCookie('Lang', culture, 14);
    document.location = $(this).attr('href');
});

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1);
        if (c.indexOf(name) == 0) return c.substring(name.length, c.length);
    }
    return "";
}

$(document).ready(function () {
    var get = getCookie("Lang");
    var lang = get == "" ? "en-gb" : get;
    $('[data-lang="' + lang + '"]').parent().addClass('active');
});

$(document).on("change", "[name='Make.Id']", function () {
    var makeId = $(this).val();
    $("[data-make]").hide();
    $("[data-make='" + makeId + "']").show();
    $("#model").val(0);
});

$(function () {
    var model = $('#model');
    $('#make').change(function () {
        if ($(this).val() == '') {
            model.prop('disabled', true);
        } else {
            model.prop('disabled', false);
        }
    });
});

function validateForm() {
    var client = $('#client').val().length;
    if (client === 0 || client == null) {
           $("#clientMassge").removeClass("hide");
           return false;
    }
    return true;
}