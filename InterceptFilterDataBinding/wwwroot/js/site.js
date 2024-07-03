// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var routeURL = location.protocol + "//" + location.host;



$(document).ready(function ()){

    $.ajax({

        url: routeURL + '/api/Request/RequestData',
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            $.each(response, function (key, value) {
                headerList.append(key + ': ' + value)
            });

         
            /*successCallback(events);*/
        },
        error: function (error) {
            console.log(error)
        }
    });
}
    


//$(document).ready(function () {
//    $("#btload").click(function () {
//        alert("clicked");
//        $.ajax({
//            url: routeURL + "/api/Request/RequestData",
//            type: "GET",
//            dataType: "json",
//            success: function (response)
//            {
//                if (response) {
//                    alert(" yes" + response.status)
//                }

//            }
//        }).done(function (data) {
//            // Some function
//            alert("success"+ url);
//        }).fail(function (handleError) {
//            // Some function
//            alert("Hehee"+url);
//        });
//    });
//});