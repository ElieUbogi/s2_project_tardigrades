<!-- Meta Données -->

	<title><?= $pinfo[0]." | ".$nomdusite; ?></title>

	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta name="author" content="<?= $auteur; ?>">
	<meta name="description" content="<?= $description; ?>">
	<link rel="icon" href="<?= $liendusite ?><?= $logo; ?>" type="image/jpg">

<!--  -->

<!-- Importations -->

	<!-- Importation de Jquery -->
	<script src="https://code.jquery.com/jquery-3.3.1.min.js" integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=" crossorigin="anonymous"></script>

	<!-- Importation FontAwesome-->
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous">

	<!-- Importation Bootstrap -->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

	<!-- CustomScrollBar -->
	<!--==
	<link rel="stylesheet" href="<?= $liendusite ?>/asset/module/scrollbar/jquery.mCustomScrollbar.css" />
	<script src="<?= $liendusite ?>/asset/module/scrollbar/jquery.mCustomScrollbar.js"></script>
	<script src="<?= $liendusite ?>/asset/js/scrollbar.js"></script>
	-->
	<?php
	if ($pinfo[2] == "home") {
		?>
		<!-- JS Effet fade -->
		<script type="text/javascript" src="<?= $liendusite ?>/asset/js/fade.js"></script>
		<!--<script type="text/javascript" src="<?= $liendusite; ?>/asset/js/iframe.js"></script> -->
		<?php
	}
	?>
	<!-- Importation des feuilles de styles -->
	<link rel="stylesheet" type="text/css" href="<?= $liendusite ?>/asset/css/style.css">
	<?php

	if (isset($pinfo[3])) {
		foreach ($pinfo[3] as $value) {
		?>
		<link rel="stylesheet" type="text/css" href="<?= $liendusite ?>/asset/css/<?= $value ?>.css">
		<?php
		}
	}

	?>
<!--  -->