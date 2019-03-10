<style type="text/css">
	form {
	margin: 0 auto;
	margin-top: 20px;
	width: 900px;
	padding: 1em;
	border: 1px solid #CCC;
	border-radius: 1em;
	}

	label {
		display: inline-block;
		width: 90px;
		text-align: right;
		font-size: 19px;
	}

	input, textarea {
		font: 1em sans-serif;
		width: 300px;
		-moz-box-sizing: border-box;
	    box-sizing: border-box;
		border: 1px solid #999;
		border-radius: 20px;
		padding: 6px;
	}

	input:focus, textarea:focus {
		border-color: #000;
	}

	textarea {
		vertical-align: top;
		height: 150px;
		resize: vertical;
	}

	.saisi{
		height: 28px;
	}

	#div1{
		display: inline-block;
		vertical-align: top;
	}

	#div2{
		display: inline-block;
		vertical-align: top;
	}

	#bouton{
		margin-top: 15px;
		display: inline-block;
	}

	#chargement{
		display: none;
		margin-top: 10px;
		vertical-align: middle;
	}

</style>
<script type="text/javascript">
	function viewImage(id) {
		document.getElementById(id).style.display = 'inline-block';
	}
</script> 
<div class="container" id="container">
	<div id="page">
		<h2><i class="fas fa-comments"></i> Page de contact</h2>
		<hr>
		<h3>Petit commentaire ... </h3>

		<form method="POST" action="">
		<center><h2>Formulaire de contact :</h2></center><br>
		<div id="div1">
			<label for="name">Prénom : </label> <input type="text" id="name" class="saisi" name="nom" placeholder="Votre prénom" value="<?php if(isset($_POST['nom'])) { echo $_POST['nom']; } ?>" /><br /><br />
			<label for="mail">Email : </label> <input type="email" id="mail" class="saisi" name="mail" placeholder="Votre email" value="<?php if(isset($_POST['mail'])) { echo $_POST['mail']; } ?>" /><br /><br />
			<label for="sujet">Sujet : </label> <input type="text" id="sujet" class="saisi" name="sujet" placeholder="La raison de votre message" value="<?php if(isset($_POST['sujet'])) { echo $_POST['sujet']; } ?>" />	
		</div>
		<div id="div2">
			<label for="message">Message : </label> <textarea id="message" name="message" placeholder="Votre message ..."><?php if(isset($_POST['message'])) { echo $_POST['message']; } ?></textarea>
		</div>
			
			<center><input type="submit" id="bouton" onclick="viewImage('chargement');" value="Envoyer !" name="mailform"/><div id="chargement" style="display: none;"><img style='width: 50px;' src="<?= $liendusite.'/asset/img/load.gif'; ?>"></div></center>
		</form>
	</div>
</div>