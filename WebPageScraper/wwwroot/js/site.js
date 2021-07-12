$(document).ready(function () {
    var slider = $('#lightSlider').lightSlider({
        item: 4,
        pager: true,
        controls: true,
        loop: false,
        slideMove: 2,
        easing: 'cubic-bezier(0.25, 0, 0.25, 1)',
        speed: 600,
        responsive: [
            {
                breakpoint: 800,
                settings: {
                    item: 3,
                    slideMove: 1,
                    slideMargin: 6,
                }
            },
            {
                breakpoint: 480,
                settings: {
                    item: 2,
                    slideMove: 1
                }
            }
        ]
    });

    $("button").click(function () {
        $("#error").hide();
        $("#word-table").empty();
        $("#word-table").append("<tr><th></th><th></th></tr>");
        $('ul').empty();
        
        $.ajax({
            type: "post",
            data: { url: $("#url").val() },
            url: "/home/getsource", success: function (result) {
                var baseUrl = $("#url").val();

                $.post("/home/getImages", { html: result, imageBase: baseUrl }, function (imageResult) {
                    $("#lightSlider").append(imageResult);
                    slider.refresh();
                });

                $.post("/home/getWords", { html: result }, function (wordResult) {
                    $("#word-table tr:last").after(wordResult);
                });

                $("#url").val("");
            }, error: function (xhr) {
                $("#url").val("");
                $("#error").show();
            }
        });
    });
});


