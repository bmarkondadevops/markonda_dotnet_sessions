$(document).ready(function () {
    $(".hero-image").hover(function () {
        
        $(this).css({
            "transform": "scale(1.05)", 
            "box-shadow": "0 8px 15px rgba(0, 0, 0, 0.2)", 
            "border": "3px solid #007bff" 
        });
    }, function () {
        
        $(this).css({
            "transform": "scale(1)", 
            "box-shadow": "none", 
            "border": "none" 
        });
    });
});