function taille()
{
	var h="";
	if (document.all)
	{
		h=document.body.clientHeight;
	}
	else
	{
		h=window.innerHeight;
	}
	document.getElementById('video').style.height = h + "px";
	document.getElementById('subsection').style.height = h + "px";
}