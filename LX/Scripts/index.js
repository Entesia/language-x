var _home;
var _index;
var _dictionary;

function initIndex(home, index, dictionary) {
    _home = home;
    _index = index;
    _dictionary = dictionary;
}

$(document).ready(function () {
    var uri = window.location.toString();
    if (uri.indexOf("?") > 0) {
        var trans = "/" + _home + "/" + _index;
        var clean_uri = uri.substring(0, uri.indexOf("?"));
        window.history.replaceState({}, document.title, clean_uri + trans);

        $.each($(".localization > a"), function (index, item) {
            var trans = "/" + _dictionary[index].home + "/" + _dictionary[index].index;
            $(item).attr("href", $(item).attr("href").split("?")[0] + trans);
        });
    }
});