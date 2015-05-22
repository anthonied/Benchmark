sendViewModelToController = function (url, data, successFunction) {
    $.ajax({
        url: getLocation(url, true),
        type: 'POST',
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (response) {
            console.log(response);
        },
        success: function (response) {
            successFunction(response);
        }
    });
}

GetDateToShow = function (dateString)
{

    var month = dateString.substr(0, dateString.indexOf("/"));
    dateString = dateString.substr(dateString.indexOf("/") + 1);


    var day = dateString.substr(0, dateString.indexOf("/"));
    dateString = dateString.substr(dateString.indexOf("/") + 1);

    var year = dateString;

    return PadLeft(day, '0', 2) + "/" + PadLeft(month, '0', 2) + "/" + year;
}