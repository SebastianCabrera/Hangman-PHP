<!DOCTYPE html>
<html>
    <head>        
        <title>Juego Ahorcado</title>
    </head>
    <body bgcolor="lightblue">
        <form action="ahorcado.php" method="post" name="formulario" id="formulario">
            <br><br>
            <h3 align="center"> AHORCADO</h3>
            
            <p align="center"><img src="imagenes/9.png"></p>
            <br>
			<!--Esto es por si se quiere jugar con una palabra que uno ingrese-->
            <!--<p align="center">palabra: <input type="password" name="palabra" id="palabra" autofocus></p> -->
            
            <p align="center"><input type="submit" name="enviar" id="enviar" value="Jugar"></p>
        </form>
    </body>
</html>
<?php
    session_start();
    $_SESSION['primeravez'] = true;
?>