<nav class="navbar navbar-expand-lg navbar-dark fixed-top">
	<div class="container">
		<a class="navbar-brand" href="<?= $liendusite ?>/<?= $lang ?>/">
			<img src="<?= $liendusite ?>/asset/img/logo.png" width="40" height="40" class="d-inline-block align-top" alt="">
			<span style="font-size: 27px; margin-left: 15px;">Escape Cube</span>
		</a>
		<ul class="navbar-nav ml-auto">
			<li class="nav-item <?php if($pinfo[2] == 'home'){echo('active');} ?>">
				<a class="nav-link" href="<?= $liendusite ?>/<?= $lang ?>/"><?= $lang_header_home ?>
				</a>
			</li>
			<li class="nav-item">
				<a class="nav-link <?php if($pinfo[2] == 'dl'){echo('active');} ?>" href="<?= $liendusite."/".$lang."/".$lang_menulien_dl ?>"><?= $lang_header_dl ?> </a>
			</li>
			<li class="nav-item dropdown">
				<a class="nav-link dropdown-toggle <?php if($pinfo[2] == 'a'){echo('active');} ?>" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
				<?= $lang_header_about ?>
				</a>
				<div class="dropdown-menu" aria-labelledby="navbarDropdown">
					<a class="dropdown-item" href="<?= $liendusite."/".$lang."/".$lang_menulien_about_1 ?>"><?= $lang_header_about_1 ?></a>
					<div class="dropdown-divider"></div>
					<a class="dropdown-item" href="<?= $liendusite."/".$lang."/".$lang_menulien_about_2 ?>"><?= $lang_header_about_2 ?></a>
				</div>
			</li>
			<li class="nav-item">
				<a class="nav-link <?php if($pinfo[2] == 'contact'){echo('active');} ?>" href="<?= $liendusite."/".$lang."/".$lang_menulien_contact ?>"><?= $lang_header_contact ?> </a>
			</li>
			<li class="nav-item">
				<div class="nav-link" style="width: 90px; height: 46px; text-align: center;">
					<div style="padding-bottom: 5px; background-color: #666; border-radius: 20px; cursor: default;">
						<a href="<?= $liendusite ?>/fr/"><img class="flag" width="20" src="<?= $liendusite ?>/asset/img/flag_fr.png"></a>
						<span style="color: lightgrey;"> | </span>
						<a href="<?= $liendusite ?>/en/"><img class="flag" width="20" src="<?= $liendusite ?>/asset/img/flag_en.png"></a>	
					</div>
				</div>
			</li>
		</ul>
	</div>
</nav>