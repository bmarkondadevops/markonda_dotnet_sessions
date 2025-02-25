// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $('#loginForm').submit(function (e) {
        e.preventDefault();
        var username = $('#username').val();
        var password = $('#password').val();

        // Here you can add your logic to handle the form data.
        // For example, you could send an AJAX request.
        $.ajax({
            type: 'POST',
            url: '/Home/Login', // Replace with your actual endpoint.
            data: { username: username, password: password },
            success: function (data) {
                console.log(data);
                alert('Form submitted successfully!');
            },
            error: function (xhr, status, error) {
                console.log(xhr.responseText);
                alert('Error submitting form!');
            }
        });
    });
});

