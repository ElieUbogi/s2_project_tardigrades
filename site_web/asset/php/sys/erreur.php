<?php
#array("type", "description")
if ($erreur == 400) {

	$erreurmsg = array("Mauvaise requête", "La requête HTTP n'a pas pu être comprise par le serveur en raison d'une syntaxe erronée. Le problème peut provenir d'un navigateur web trop récent ou d'un serveur HTTP trop ancien.");

}elseif ($erreur == 401) {

	$erreurmsg = array("Non autorisé", "La requête nécessite une identification de l'utilisateur. Concrètement, cela signifie que l'ensemble ou une partie du serveur contacté est protégé par un mot de passe qu'il faut indiquer au serveur pour accéder à son contenu.");

}elseif ($erreur == 403) {

	$erreurmsg = array("Interdit", "Le serveur HTTP a compris la requête, mais refuse de la traiter. Ce code est généralement utilisé lorsqu'un serveur ne souhaite pas indiquer pourquoi la requête a été rejetée, ou lorsqu'aucune autre réponse ne correspond.");


}elseif ($erreur == 404) {

	$erreurmsg = array("Page non trouvée", "Le serveur n'a rien trouvé qui corresponde à l'adresse (URL) demandée. Cela signifie que l'URL que vous avez tapée ou cliquée est mauvaise ou obsolète et ne correspond à aucun document existant sur le serveur (vous pouvez essayez de supprimer progressivement les composants de l'URL en partant de la fin pour éventuellement retrouver un chemin d'accès existant).");


}elseif ($erreur == 500) {

	$erreurmsg = array("Erreur interne du serveur", "Le serveur HTTP a rencontré une condition inattendue qui l'a empêché de traiter la requête. Cette erreur peut par exemple être le résultat d'une mauvaise configuration du serveur ou d'une ressource épuisée ou refusée au serveur sur la machine hôte.");

}elseif ($erreur == "nor") {

	$erreurmsg = array("Lien non trouvé", "Le lien de redirection que vous avez entré n'existe pas/plus. Merci d'en informer la personne qui vous la passé.");

}elseif ($erreur == "lang01") {

	$erreurmsg = array("Langue non trouvé | Language not found", "La langue que vous avez entré n'existe pas/plus. | The language you entered does not exist (anymore)");

}else{
	
	$erreurmsg = array("Erreure inconnue", "Merci de signaler à l'administateur comment cette erreure s'est produite.");

}
?>