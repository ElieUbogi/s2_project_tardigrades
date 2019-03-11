<?php
#array(nom_de_la_page, chemin, id_associé_au_menu, liste_des_styles_a_importer)
if (isset($_GET['lang'])) {

	$lang = $_GET['lang'];

	if ($lang == "fr") {
		require("asset/lang/fr.php");
	}elseif ($lang == "en") {
		require("asset/lang/en.php");
	}else{
		$lang = "fr";
		$erreur = "lang01";
		require("asset/php/sys/erreur.php");
		$pinfo = array("Error type ".$erreur, "asset/page/erreur.php");
	}
}else{
	header("Location: fr/");
	die();
}

if (isset($_GET['erreur'])) {

	$erreur = $_GET['erreur'];
	require("asset/php/sys/erreur.php");
	$pinfo = array($lang_titre_erreur.$erreur, "asset/page/erreur.php");

}

if (!isset($erreur)) {

	if (isset($_GET['page'])) {

		$page = $_GET['page'];

		/*if ($page == "accueil" OR $page == "home") {

		$pinfo = array($lang_titre_home, "asset/page/home.php");}*/

		if ($page == $lang_menulien_dl){

			$pinfo = array($lang_header_dl, "asset/page/dl.php", "dl", array("dl"));

		}elseif ($page == $lang_menulien_about_1) {

			$pinfo = array($lang_header_about." ".$lang_header_about_1, "asset/page/game.php", "a", array("jeu"));
			
		}elseif ($page == $lang_menulien_about_2) {

			$pinfo = array($lang_header_about." ".$lang_header_about_2, "asset/page/equipe.php", "a", array("equipe", "modal"));
			
		}elseif ($page == $lang_menulien_contact) {

			$pinfo = array($lang_header_contact, "asset/page/contact.php", "contact", array("contact"));
			
		}else{

			$erreur = "404";
			require("asset/php/sys/erreur.php");
			$pinfo = array($lang_titre_erreur.$erreur, "asset/page/erreur.php");

		}
	}else{

		$pinfo = array($lang_titre_home, "asset/page/home.php", "home", array("home"));

	}
}
?>