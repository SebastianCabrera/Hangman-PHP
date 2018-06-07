<?php session_start();?>
<!DOCTYPE html>
<html>
    <head>        
        <title>Juego Ahorcado</title>
    </head>
    <body bgcolor="lightblue">
        <form action="" method="post" name="formletra" id="formletra">
            <p align="center">letra: <input type="text" name="letra" id="letra" autofocus></p>
          
            <p align="center"><input type="submit" name="Verificar" id="Verificar" value="Verificar"></p>
        </form>
    </body>
</html>



<?php
	//2. No se pueden usar variables globales en vez de usar $_SESSION?
	//1. Se podrá acomodar en forma de funciones para que sea más manejable?
	//3. Voy a ver si se puede llamar a este archivo 'index' y que comience desde aquí
	//	|->La parte de un menú se podría agregar en Visual
	//DEFINIR BIEN cuando se le da el valor a $letra OJO
    //session_start();
	include 'funciones.php';
	
	$hangman = new Hangman();
	
	if(isset($_POST['letra']))
	{
		$hangman->letra = $_POST['letra'];	
	}
	
	$hangman->startGame();
	
	$palabraReal = $hangman->palabraIngresada;
	
	$palabraEscondida = $hangman->hidden();
		
	$palabraEscondida = $hangman->checkAndReplace($palabraEscondida);
	
	$palabraEscondida = $hangman->checkGameOver($palabraEscondida);
	
	//La imagen que se muestra dependiendo del numero de intentos
	switch ($hangman->intentos){
		case 0:
			echo '<p align="center"><img src="imagenes/0.png"></p>';
			break;
		case 1:
			echo '<p align="center"><img src="imagenes/1.png"></p>';
			break;
		case 2:
			echo '<p align="center"><img src="imagenes/2.png"></p>';
			break;
		case 3:
			echo '<p align="center"><img src="imagenes/3.png"></p>';
			break;
		case 4:
			echo '<p align="center"><img src="imagenes/4.png"></p>';
			break;
		case 5:
			echo '<p align="center"><img src="imagenes/5.png"></p>';
			break;
		case 6:
			echo '<p align="center"><img src="imagenes/6.png"></p>';
			break;
		case 7:
			echo '<p align="center"><img src="imagenes/7.png"></p>';
			break;
		case 8:
			echo '<p align="center"><img src="imagenes/8.png"></p>';
			break;
//        case 9:
//            echo '<img src="imagenes/9.png">';
//            break;
		default:
			echo '';
	}
?>