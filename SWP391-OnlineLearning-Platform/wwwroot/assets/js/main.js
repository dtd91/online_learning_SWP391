"use strict";

$(function() {

	$(".rslides-header").responsiveSlides({
		prevText: '<i class="zmdi zmdi-chevron-left zmdi-hc-2x text-center"></i>',
		nextText: '<i class="zmdi zmdi-chevron-right zmdi-hc-2x text-center"></i>',
		nav: true
	});

	$(".scrolldown").on("click", function(){
		$("html,body").animate({
			scrollTop: $("header").height()
		});
	});

	$(".slick-features").slick({
		slidesToShow: 5,
		prevArrow: '<i class="zmdi zmdi-chevron-left zmdi-hc-2x text-center"></i>',
		nextArrow: '<i class="zmdi zmdi-chevron-right zmdi-hc-2x text-center"></i>',
		responsive: [
		{
			breakpoint: 1200,
			settings: {
				slidesToShow: 3
			}
		},
   		{
			breakpoint: 992,
			settings: {
				slidesToShow: 2
			}
		},
		{
			breakpoint: 768,
			settings: {
				slidesToShow: 1
			}
		}]
	});

	$(".slick-testimonials").slick({
		slidesToShow: 1,
		prevArrow: '<i class="zmdi zmdi-chevron-left text-center"></i>',
		nextArrow: '<i class="zmdi zmdi-chevron-right text-center"></i>',
	});

	$(".popular-scrolldown").on("click", function(){
		$('html,body').animate({
          scrollTop: $(".tutorials").offset().top - 50
        }, 1000);
	});

	var $teacher = 	$(".teacher > a");

	$teacher.hover(function(){
		$(this).siblings(".imgcontainer").find(".overlay").fadeIn();
	});

	$teacher.mouseout(function(){
		$(this).siblings(".imgcontainer").find(".overlay").fadeOut();
	});

	$(".jquery-select").selectmenu();

	$("#teacher-single .tutorials").slick({
		slidesToShow: 3,
		prevArrow: '<i class="zmdi zmdi-chevron-left text-center"></i>',
		nextArrow: '<i class="zmdi zmdi-chevron-right text-center"></i>',
		responsive: [
   		{
			breakpoint: 992,
			settings: {
				slidesToShow: 2
			}
		},
		{
			breakpoint: 768,
			settings: {
				slidesToShow: 1
			}
		}]
	});

	$(".option-title").on("click", function(){
		var $parent = $(this).parent();
		$parent.addClass("opened");
		$parent.siblings().removeClass("opened");
	});

	$(".courses-side-slick").slick({
		slidesToShow: 1,
		prevArrow: '<i class="zmdi zmdi-chevron-left text-center"></i>',
		nextArrow: '<i class="zmdi zmdi-chevron-right text-center"></i>'
	});

	$(".loadmore").on("click", function(e){
		$(this).fadeOut(500);
		$(".more-categories").slideDown(700);
		$(".service-categories").animate({"margin-bottom": 0}, 700);
		e.preventDefault();
	});


	if(window.innerWidth < 768){
		var $items = $("#myNavbar > ul > li > a");
		$items.each(function(i, el){
			if($(el).attr("href") == "#"){
				$(this).on("click",function(e){
					e.preventDefault();
					$(".submenu").hide();
					$(this).siblings(".submenu").show();

				});
			}
		});
	}

	var PlaceHolderElement = $('#PlaceHolderHere');
	$('button[data-toggle="ajax-modal"]').click(function (event) {
		var url = $(this).data('url');
		var decodeUrl = decodeURIComponent(url);
		$.get(decodeUrl).done(function (data) {
			PlaceHolderElement.html(data);
			PlaceHolderElement.find('.modal').modal('show');
		})
	})

	PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {
		event.preventDefault();
		var form = $(this).parents('.modal').find('form');
		var actionUrl = form.attr('action');
		var sendData = form.serialize();
		$.post(actionUrl, sendData).done(function (data) {
			PlaceHolderElement.find('.modal').modal('hide');
		})
	})

	$().fancybox({
		selector: 'a.popup-fancy',
		type: 'iframe',
		baseClass: 'fancybox-md',
		iframe: {
			preload: false
		}
	});

	$().fancybox({
		selector: 'a.popup-fancy-lg',
		type: 'iframe',
		baseClass: 'fancybox-lg',
		iframe: {
			preload: false
		}
	});

	$().fancybox({
		selector: 'a.popup-fancy-xl',
		type: 'iframe',
		baseClass: 'fancybox-xl',
		iframe: {
			preload: false
		}
	});

	$().fancybox({
		selector: 'a.popup-fancy-xxl',
		type: 'iframe',
		baseClass: 'fancybox-xxl',
		iframe: {
			preload: false
		}
	});

	$('a.complaint-detail').click(function () {
		let detailId = $(this).data('complaint-detail-id'),
			url = '@Url.Action("CourseDetail", "Course", new { area = "" })/' + detailId,
			$modal = $('#complaint-detail-modal'),
			$iframe = $modal.find('iframe');

		// Change the source of the iframe to the url
		$iframe.prop('src', url);    // Or you can use $iframe.attr('src', url);

		// Manually trigger the modal
		$modal.modal('show');

		return false;
	});
	
});