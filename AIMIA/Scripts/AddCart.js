

var urls = {
    addCart: "../Cart/Add"
};

///Add the Cart
function addCart() {
    var a = "sad";
    $.ajax({
        type: "POST",
        dataType: "json",
        url: urls.addCart,
        //async: false,
        //cache:false,
        data: {
            id: 1,
            count: $("#cartItems").val(),
            PetId: 1,
            PetName: "Riley"
        },
        success: function (statusResult) {
            if (statusResult > 0) {
                $("#cartItems").val(statusResult);
                $("#CartCount").css("display", "block");
                $("#CartCount").text(statusResult);
                $('#successMessage').show();
            }
        },
        error: function (err) {
            $('#errorMessage').show();
        }
    });
}


