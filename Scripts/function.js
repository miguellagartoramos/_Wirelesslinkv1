$(document).ready(function () {
    //SIDE MENU
    (function ($) {

        $('#header-icon').click(function (e) {
            e.preventDefault();
            $('body').toggleClass('sidebar');
        });

        $('#site-body').click(function (e) {
            $('body').removeClass('sidebar');
        });

    })(jQuery);


    //SLIDER
    $('.slider').slider({ full_width: true });

    //WOW
    var wow = new WOW(
        {
              boxClass: 'wow',      // animated element css class (default is wow)
              animateClass: 'animated', // animation css class (default is animated)
              offset: 0,          // distance to the element when triggering the animation (default is 0)
              mobile: false       // trigger animations on mobile devices (true is default)
          }
        );
    wow.init();

    /*Scroll function*/

    var scrollButton = $("#scroll");

    $(window).scroll(function () {
        $(this).scrollTop() >= 500 ? scrollButton.fadeIn() : scrollButton.fadeOut();
    });
    scrollButton.click(function () {
        $("html,body").animate({ scrollTop: 0 }, 650);
    });

    /*Mapbox function*/
    $(document).ready(function () {
        if ($("div#map")) {
            L.mapbox.accessToken = 'pk.eyJ1IjoibWlndWVsbGFnYXJ0b3JhbW9zIiwiYSI6IjZjNTViMjQ3YWY1NGU3YTIyZDI0MDBhOGZlYTU0Nzk3In0.GaKEQJivmpgrBXiFcPzpwA';
            var map = L.mapbox.map('map', 'miguellagartoramos.pe1jfi2h')
                .setView([14.610388, 121.02423199999998], 19)
                .addLayer(L.mapbox.tileLayer('miguellagartoramos.pe1jfi2h', {
                    detectRetina: true,
                    retinaVersion: 'miguellagartoramos.pe1jfi2h'
                }));
            // disable drag and zoom handlers
            map.dragging.disable();
            map.touchZoom.disable();
            map.doubleClickZoom.disable();
            map.scrollWheelZoom.disable();
        }
    });

    $('.parallax').parallax();

    $('.materialboxed').materialbox();

    // Cache selectors
    var lastId,
        topMenu = $(".top-menu"),
        topMenuHeight = topMenu.outerHeight() + 15,
        // All list items
        menuItems = topMenu.find("a"),
        // Anchors corresponding to menu items
        scrollItems = menuItems.map(function () {
            var item = $($(this).attr("href"));
            if (item.length) { return item; }
        });

    //scroll animation
    menuItems.click(function (e) {
        var href = $(this).attr("href"),
            offsetTop = href === "#" ? 0 : $(href).offset().top - topMenuHeight + 1;
        $('html, body').stop().animate({
            scrollTop: offsetTop
        }, 600);
        e.preventDefault();
    });

            //config vars
        var lagAmount = 50;
        var maxSpeed = 100;
        var frameRate = 0;
        //var frameRate = 20;
        var selector = '.pin';
        //code
        var scrollTop = 0;
        var pinTop = 0;
        var lastTime = void 0;
        var updatePinPosition = function updatePinPosition(time) {
            if (!lastTime) lastTime = time;
            var delta = time - lastTime;
            if (delta >= frameRate) {
                scrollTop = $(window).scrollTop();
                var move = (scrollTop - pinTop) * delta / (lagAmount + delta);
                var direction = move === 0 ? 0 : move / Math.abs(move);
                pinTop = pinTop + Math.min(Math.abs(move), maxSpeed) * direction;
                $(selector).css('transform', 'translateY(' + -move + 'px');
                lastTime = time;
            }
            requestAnimationFrame(updatePinPosition);
        };
        requestAnimationFrame(updatePinPosition);

}); 