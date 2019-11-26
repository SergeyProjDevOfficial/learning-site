$(document).ready(function () {

    $('.func-send-btn').on('click', function (e) {
        e.preventDefault();

        var url = "https://localhost:44393/api/SendEmail";

        var dataJSON = {
            "Name": document.getElementById('name').value,
            "Email": document.getElementById('email').value,
            "Body": document.getElementById('message').value
        };

        if (dataJSON.Name && dataJSON.Email && dataJSON.Body) {
            var success = function (data) {   // success callback function
                alert(data);
            }
            var error = function (errorMessage) { // error callback 
                alert(errorMessage);
            }
            send(url, dataJSON, success, error);
        } else {
            alert('All inputs should be filled!');
        }
    });
});

function send(url, data, onSuccess, onError) {
        $.ajax(url,
            {
            contentType: 'application/json',
            type: 'POST',
            data: JSON.stringify(data),
            success: onSuccess,
            error: onError
        });
}