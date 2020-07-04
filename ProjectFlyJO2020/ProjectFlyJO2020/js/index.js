function deferVideo() {

    //defer html5 video loading
  $("video source").each(function() {
    var sourceFile = $(this).attr("data-src");
    $(this).attr("src", sourceFile);
    var video = this.parentElement;
    video.load();
    // uncomment if video is not autoplay
    //video.play();
  });

}
window.onload = deferVideo;

/*NAV toggle */
let mainNav = document.getElementById("js-menu");
let navBarToggle = document.getElementById("js-navbar-toggle");

navBarToggle.addEventListener("click", function() {
  mainNav.classList.toggle("active");
});


$(document).ready(function () {
    $('#nav').addClass('glasscolor');
    $('.navmob').addClass('glasscolor');

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

// BY KAREN GRIGORYAN

 

$(document).ready(function () {
    $(".go_top").click(function () {
        $('html, body').animate({
            scrollTop: $("body").offset().top
        }, 500);
    });
});

document.getElementsByClassName("card").onclick = function () { myFunction() };

function myFunction() {
    document.getElementsByClassName("card").innerHTML = "YOU CLICKED ME!";
}

document.getElementById("barca").onclick = function () { Barcelona() };

function Barcelona() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'BCN');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}

document.getElementById("madrid").onclick = function () { Madrid() };

function Madrid() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'MAD');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}


document.getElementById("man").onclick = function () { MAN() };

function MAN() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'MAN');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}


document.getElementById("London").onclick = function () { London() };

function London() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'YXU');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}

document.getElementById("Paris").onclick = function () { Paris() };

function Paris() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'LBG');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}

document.getElementById("Milan").onclick = function () { Milan() };

function Milan() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'LIN');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}


document.getElementById("istanbul").onclick = function () { istanbul() };

function istanbul() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'TRK');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}


document.getElementById("munich").onclick = function () { munich() };

function munich() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'MUC');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}
//-----------------------------------------------------------------------------
document.getElementById("moscow").onclick = function () { moscow() };

function moscow() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'SVO');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}

document.getElementById("cairo").onclick = function () { cairo() };

function cairo() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'CAI');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}


document.getElementById("dubai").onclick = function () { dubai() };

function dubai() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'DXB');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}


document.getElementById("delhi").onclick = function () { delhi() };

function delhi() {
    document.getElementById("autocomplete").setAttribute('value', 'AMM');
    document.getElementById("autocomplete2").setAttribute('value', 'DEL');
    $('html, body').animate({
        scrollTop: $("body").offset().top
    }, 500);
}

//Testmonial 

jQuery(document).ready(function ($) {
    "use strict";
    //  TESTIMONIALS CAROUSEL HOOK
    $('#customers-testimonials').owlCarousel({
        navigation: true,
        loop: true,
        center: true,
        items: 3,
        margin: 0,
        autoplay: true,
        dots: true,
        autoplayTimeout: 8500,
        smartSpeed: 450,
        responsive: {
            0: {
                items: 1
            },
            768: {
                items: 2
            },
            1170: {
                items: 3
            }
        }
    });
});