$(window).on("scroll", function() {
	if($(window).scrollTop() > 500) {
		$(".navbar").addClass("scrollnav");
	} else {
		$(".navbar").removeClass("scrollnav");
	}
});

$(window).on("scroll", function() {
	if($(window).scrollTop() > 60) {
		$(".footer").addClass("scrollfooter");
	} else {
		$(".footer").removeClass("scrollfooter");
	}
});

$(window).on("scroll", function() {
	if($(window).scrollTop() > $('#subsection').height()-$('#subsection').height()*0.30) {
		$(".subelem").addClass("subelemactive");
	}
});