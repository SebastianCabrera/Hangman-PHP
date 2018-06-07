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
  include "classAhorcado.php";
  //if($juego->intentos==0) {
	 
	  $juego = new Ahorcado;
	  $juego->iniciarJuego();
  
      if($juego->mostrarAhorcado('v')){
		  echo 'true';
	  }


?>