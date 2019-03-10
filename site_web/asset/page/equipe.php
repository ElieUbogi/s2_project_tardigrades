<?php
require("asset/php/sys/infoequipe.php");
?>
<div class="container" id="container">
	<div id="page">
		<h2><i class="fas fa-users"></i> Page présentation équipe</h2>
		<hr>
		<div style="text-align: center;">
			<?php
			for ($j=0; $j <= $i; $j++) { 
				?>
				<div class="photo">
					<a href="javascript:void(0)" data-toggle="modal" data-target="#<?= ${'id'.$j}[2] ?>"><img width="150px;" alt="Image de <?= ${'id'.$j}[0] ?>" src="<?= $liendusite; ?>/asset/img/photo/<?= ${'id'.$j}[1] ?>.jpg"><div><?= ${'id'.$j}[0] ?></div></a>
				</div>
				<?php
			}
			?>
		</div>
		<?php
		for ($j=0; $j <= $i; $j++) { 
		?>
			<div class="modal fade" id="<?= ${'id'.$j}[2] ?>" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
				<div class="modal-dialog" role="document">
					<div class="modal-content">
						<div class="modal-header">
							<h5 class="modal-title" id="exampleModalLabel">Informations sur <?= ${'id'.$j}[0] ?></h5>
							<button type="button" class="close" data-dismiss="modal" aria-label="Close">
							<span aria-hidden="true">&times;</span>
							</button>
						</div>
						<div class="modal-body">

						</div>
						<div class="modal-footer">
							<button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
						</div>	
					</div>
				</div>
			</div> 
		<?php
		}
		?>
	</div>
</div>