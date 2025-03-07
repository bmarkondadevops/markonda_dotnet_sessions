
    $(document).ready(function() {
        console.log("Document ready.");
        $("#emailForm").on("submit", function(event) {
            event.preventDefault();
            console.log("Form submitted.");
            fnValidateEmail();
        });

        async function fnValidateEmail() {
            var email = $("#email").val();
            console.log("Email:", email);

            $("#imgLoading").show();
            $("#emailValidationMessage").empty();

            await $.post("/Home/ValidateEmail", { email: email }, function(response) {
                console.log("Response:", response);
                $("#emailValidationMessage").html(response);
                if (response === "Email already exists") {
                    $("#emailValidationMessage").css("color", "red");
                } else {
                    $("#emailValidationMessage").css("color", "green");
                }
                $("#imgLoading").hide();
            }).fail(function() {
                console.log("Error occurred.");
                $("#emailValidationMessage").html("An error occurred.");
                $("#emailValidationMessage").css("color", "red");
                $("#imgLoading").hide();
            });
        }
    });
