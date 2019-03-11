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
			<center><h2>Formulaire de contact :</h2></center>
			<br>

			<div id="div1">
				<label for="name">Prénom : </label>
				<input type="text" id="name" class="saisi" name="nom" placeholder="Votre prénom" value="<?php if(isset($_POST['nom'])) { echo $_POST['nom']; } ?>" />
				<br /><br />
				<label for="mail">Email : </label>
				<input type="email" id="mail" class="saisi" name="mail" placeholder="Votre email" value="<?php if(isset($_POST['mail'])) { echo $_POST['mail']; } ?>" />
				<br /><br />
				<label for="sujet">Sujet : </label>
				<input type="text" id="sujet" class="saisi" name="sujet" placeholder="La raison de votre message" value="<?php if(isset($_POST['sujet'])) { echo $_POST['sujet']; } ?>" />	
			</div>

			<div id="div2">
				<label for="message">Message : </label>
				<textarea id="message" name="message" placeholder="Votre message ..."><?php if(isset($_POST['message'])) { echo $_POST['message']; } ?>
				</textarea>
			</div>
			
			<center>
				<input type="submit" id="bouton" onclick="viewImage('chargement');" value="Envoyer !" name="mailform"/>
				<div id="chargement" style="display: none;"><img style='width: 50px;' src="<?= $liendusite.'/asset/img/load.gif'; ?>"></div>
			</center>
		</form>
	</div>
</div>