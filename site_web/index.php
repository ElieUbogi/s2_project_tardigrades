<?php
	require("asset/php/config.php");
	require("asset/php/sys/maintenance.php");
	require("asset/php/sys/whatpage.php");
?>
<html>
	<head>
		<?php require("asset/php/app/head.php"); ?>
		<script type="text/javascript" src="<?= $liendusite; ?>/asset/js/taille.js"></script>
	</head>
	<body>
		<?php 
			require("asset/php/app/header.php");
		?>
		<div id="contenu" style="">
			<?php
			require($pinfo[1]);
			require("asset/php/app/footer.php");
			?>
		</div>
	</body>
</html>