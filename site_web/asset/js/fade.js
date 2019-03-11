$(document).ready(function(){
	$(".footer").css("bottom", "-60px");
	$(".navbar").css("background-color", "rgba(11,31,36,0.2)");
})
$(window).on("scroll", function() {
	if($(window).scrollTop() > 500) {
		$(".navbar").css("background-color", "rgba(11,31,36,0.9)");
	} else {
		$(".navbar").css("background-color", "rgba(11,31,36,0.2)");
	}
});

$(window).on("scroll", function() {
	if($(window).scrollTop() > 60) {
		$(".footer").css("bottom", "0px");
	} else {
		$(".footer").css("bottom", "-60px");
	}
});

$(window).on("scroll", function() {
	if($(window).scrollTop() > $('#subsection').height()-$('#subsection').height()*0.30) {
		$(".subelem").addClass("subelemactive");
	}
});