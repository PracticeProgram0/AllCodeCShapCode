

function JsonGet() {
    $.ajex(
        type: "Get",
        url: "/home/JsonData",

        success: function (response)
        let obj = JSON.parse(response)
        let name = obj.Name;
        let age = obj.Age;
        let phone = obj.Phone;
       let ispass = obj.ispass;

    $('#nameValue').text(name);
    $('#ageValue').text(age);
    $('#phoneValue').text(phone);
    $('#ispassValue').text(ispass){
        error: function(error) {
            alert(error);
        }
    }


    )
}