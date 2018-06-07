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
	//Se podrá acomodar en forma de funciones para que sea más manejable?
	//Voy a ver si se puede llamar a este archivo 'index' y que comience desde aquí
	//	|->La parte de un menú se podría agregar en Visual
	//Que se devuelva la hilera escondida
    session_start();    
    
	//El de iniciar el juego no lo voy a hacer una funcion
    if ($_SESSION['primeravez']){
        //Numero de intentos de usuario
        $_SESSION['intentos'] = -1;
		//El .txt con las palabras
        $contenido = file("palabras.txt");
        $linea_azar = $contenido[rand(0, count($contenido) - 1)];
		$linea_azar = trim($linea_azar);
		//Palabra dividida en letras escogida al azar de $contenido
       	$_SESSION['palabraingresada']= $linea_azar;
		//No mostrar la respuesta a menos que se esten haciendo pruebas
        //echo $_SESSION['palabraingresada'];
		//Longitud de la palabra elegida
        $_SESSION['longitud'] = strlen($_SESSION['palabraingresada']);
		     
        //Letras que se pueden usar como intento valido
        $_SESSION['permitidos'] = " -abcdefghijklmnopqrstuvwxyz";
        
		$_SESSION['ahorcado'] = hidden();
		
		/*
		//Hilera de '_' del tamano de la palabra escogida
        for ($i = 0; $i < $_SESSION['longitud']; $i++){
            $_SESSION['ahorcado'][$i] = '_';
        }
		*/
        $_POST['letra'] = ' ';
        $_SESSION['primeravez'] = false;
    }

    $_SESSION['letra'] = $_POST['letra'];
    
	//Se verifica si se ingreso una letra como intento
    $letraVacia = false;
    if ($_SESSION['letra'] == ''){
        $letraVacia = true;
        $_SESSION['letra'] = '-';
        echo '<script type = "text/javascript">
            alert("DEBE INGRESAR UNA LETRA");            
        </script>';
    }
    
	//Se verifica si la letra es permitida
    $indicadorLetraPermitida = true;
    if (stripos($_SESSION['permitidos'], $_SESSION['letra']) === false){
        echo '<script type = "text/javascript">
            alert("La letra no es valida");            
        </script>';
        $indicadorLetraPermitida = false;
    }
    
	//Se guardan todas las letras ya utilizadas para eviatr que sean repetidas
    if ($indicadorLetraPermitida == true && $_SESSION['letra'] != '-'){
        $_SESSION['LetraIngresada'][] = $_SESSION['letra'];
    }
	
	$indicadorIntentos = checkAndReplace();
    
	/*
	//Si la letra esta en la palabra, se sustituye en la hilera de '_'
    $indicadorIntentos = false;
    for ($i = 0; $i < $_SESSION['longitud']; $i++){
        if ($_SESSION['palabraingresada'][$i] == $_SESSION['letra']){
            $_SESSION['ahorcado'][$i] = $_SESSION['letra'];
            $indicadorIntentos = true;
        }
    }
	*/
    
	//Se verifica que la letra no haya sido ingresada antes
    $contadorLetras = 0;   
    $indicadorLetraIn = false;
    if ($_SESSION['letra'] != ' '){
        for ($i=0; $i<count($_SESSION['LetraIngresada']); $i++){
            if ($_SESSION['LetraIngresada'][$i] == $_SESSION['letra']){            
//                $i = count($_SESSION['LetraIngresada']) + 1;
                $contadorLetras ++;                
            }
        }        
        if ($contadorLetras >= 2){
            echo '<script type = "text/javascript">
            alert("La letra ya ha sido ingresada");            
        </script>';
            $indicadorLetraIn = true;
        }
    }
    
	//Solo se cuenta como un intento si cumple con todas las reglas
    if ($indicadorIntentos == false && $indicadorLetraPermitida == true && $indicadorLetraIn == false && $letraVacia == false){
        $_SESSION['intentos'] ++;
    }
    
	checkGameOver();
	/*
	//Verifica si ya se gano el juego
    $aux = 0;
    for ($j=0; $j<$_SESSION['longitud']; $j++){
        if ($_SESSION['palabraingresada'][$j] == $_SESSION['ahorcado'][$j]){
            $aux++;
        }
    }    
    if ($aux == $_SESSION['longitud']){
        echo '<br>';
        ?>
        <html>
            <p align="center">
			<!--Si se gana el juego se imprime la palabra encontrada-->
                <?php 
                    for ($k=0; $k<$_SESSION['longitud']; $k++){        
                        echo $_SESSION['ahorcado'][$k] . ' ';
                    }
                ?>
            </p>
        </html>
        <?php
        echo '<script type = "text/javascript">
            alert("FELICIDADES!! HA GANADO!!");
        </script>';
        mensajeJugarNuevamente();
    }
    
	//Se verifica si ha perdido el juego
    if ($_SESSION['intentos'] == 9){
        echo '<img src="imagenes/9.png">';
        sleep(0.2);
        echo '<br>';
        ?>
        <html>
            <p align="center">
                <?php 
                    for ($k=0; $k<$_SESSION['longitud']; $k++){        
                        echo $_SESSION['palabraingresada'][$k] . ' ';
                    }
                ?>
            </p>
        </html>
<?php
    echo '<script type = "text/javascript">
        alert("HA PERDIDO");;
    </script>';
    mensajeJugarNuevamente();
    }else{
        echo '<p align="center">Lleva ' . $_SESSION['intentos'] . '  intentos fallidos</p>';
    }
?>
<html>
    <p align="center">
        <?php 
            for ($k=0; $k<$_SESSION['longitud']; $k++){        
                echo $_SESSION['ahorcado'][$k] . ' ';
            }
        ?>
    </p>
</html>  
  
<?php
*/
	//La imagen que se muestra dependiendo del numero de intentos
    switch ($_SESSION['intentos']){
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
    function mensajeJugarNuevamente(){
        session_destroy();
        echo '<script type="text/javascript">            
            if (confirm("DESEA JUGAR DE NUEVO?") == true) {
                window.location = "index.php";
            }else{
                window.location = "http://www.google.com";
            }
        </script>';
    }
	
	function hidden()
	{
		$ahorcado = $_SESSION['palabraingresada']; //Para el tamano
		for ($i = 0; $i < $_SESSION['longitud']; $i++){
            //$_SESSION['ahorcado'][$i] = '_';
			$ahorcado[$i] = '_';
        }
		return $ahorcado;
	}
	
	function checkAndReplace()
	{
		$indicadorIntentos = false;
		for ($i = 0; $i < $_SESSION['longitud']; $i++){
			if ($_SESSION['palabraingresada'][$i] == $_SESSION['letra']){
				$_SESSION['ahorcado'][$i] = $_SESSION['letra'];
				$indicadorIntentos = true;
			}
		}
		return $indicadorIntentos;
	}
	
	function checkGameOver()
	{
		$aux = 0;
		for ($j=0; $j<$_SESSION['longitud']; $j++){
			if ($_SESSION['palabraingresada'][$j] == $_SESSION['ahorcado'][$j]){
				$aux++;
			}
		}    
		if ($aux == $_SESSION['longitud']){
			echo '<br>';
			?>
			<html>
				<p align="center">
				<!--Si se gana el juego se imprime la palabra encontrada-->
					<?php 
						for ($k=0; $k<$_SESSION['longitud']; $k++){        
							echo $_SESSION['ahorcado'][$k] . ' ';
						}
					?>
				</p>
			</html>
			<?php
			echo '<script type = "text/javascript">
				alert("FELICIDADES!! HA GANADO!!");
			</script>';
			mensajeJugarNuevamente();
		}
		
		//Se verifica si ha perdido el juego
		if ($_SESSION['intentos'] == 9){
			echo '<img src="imagenes/9.png">';
			sleep(0.2);
			echo '<br>';
			?>
			<html>
				<p align="center">
					<?php 
						for ($k=0; $k<$_SESSION['longitud']; $k++){        
							echo $_SESSION['palabraingresada'][$k] . ' ';
						}
					?>
				</p>
			</html>
	<?php
		echo '<script type = "text/javascript">
			alert("HA PERDIDO");;
		</script>';
		mensajeJugarNuevamente();
		}else{
			echo '<p align="center">Lleva ' . $_SESSION['intentos'] . '  intentos fallidos</p>';
		}
	?>
	<html>
		<p align="center">
			<?php 
				for ($k=0; $k<$_SESSION['longitud']; $k++){        
					echo $_SESSION['ahorcado'][$k] . ' ';
				}
			?>
		</p>
	</html>    
	<?php
	}
?>