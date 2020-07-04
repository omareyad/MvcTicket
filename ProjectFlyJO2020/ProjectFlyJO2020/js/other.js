function inViewport($el) {
    var H = $(window).height(),
        r = $el[0].getBoundingClientRect(), t = r.top, b = r.bottom;
    return Math.max(0, t > 0 ? H - t : (b < H ? b : H));
}

$(window).on("scroll resize", function () {
    var window_offset = inViewport($('.intro'));
    $(".overlay").height(window_offset / 2);
    $(".caption").css("bottom", (window_offset / 3));
});


$(document).ready(function () {

    $(document).scroll(function () {
        var y = $(this).scrollTop();
        if (y > 250) {


            
           
            $('.navbar1').addClass('shadowNav');
        } else {
            $('.navbar1').removeClass('shadowNav');
            

        }

    })
});

$(document).ready(function () {
    document.getElementById('g_top').style.display = "none";
    $(document).scroll(function () {
        var y = $(this).scrollTop();
        if (y > 390) {

            document.getElementById('g_top').style.display = "block";
        } else {
           
            document.getElementById('g_top').style.display = "none";

        }

    })
});


$(document).ready(function () {
    $(".go_top").click(function () {
        $('html, body').animate({
            scrollTop: $("body").offset().top
        }, 500);
    });
});
