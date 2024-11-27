function GetDataByAjax() {
    $.ajax({
        type: "GET",
        url: "/Home/AjexCallGET",
        success: function (response) {
            alert(response);
        },
        error: function (error) {
            alert(error);
        }
    });
}

function PostDataByAjax() {

    let objectData = GetValues();
    $.ajax({
        type: "POST",
        url: "/Home/AjaxCallPost",
        data: objectData,
        success: function (response) {
            alert(response);
        },
        error: function (error) {
            alert(error);
        }
    });
}
function GetValues() {

    let username = $('#Username').val();
    let pass = $('#Password').val();

    let obj = {
        UserName: username,
        Password : pass
    }
    return obj;
}

function JsonGet() {
    $.ajax({
        type: "GET",
        url: "/Home/JsonData",
        success: function (response) {
            let obj = JSON.parse(response)




            alert(response);
        },
        error: function (error) {
            alert(error);
        }
    });
}