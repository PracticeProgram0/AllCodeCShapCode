

function JsonGet() {
    $.ajax(
        type: "Get",
        url: "/home/JsonData",

        success: function (respose) {
            let obj = JSON.parse(respose)
            let name = obj.Name;
            let age = obj.Age;
            let phone = obj.Phone;
            let ispass = obj.IaPass;
            $('#nameValue').text(name);
            $('#ageValue').text(age);
            $('#phoneValue').text(phone);
            $('#ispassValue').text(ispass);

            error: function(error) {
                alert(error);
            }
        }
    )






}