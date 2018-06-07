<?php
	class Hangman
	{
		public $primeraVez = true; //revisar
		public $intentos = 0;
		//Palabra que hay que adivinar en cada caso
		public $palabraIngresada = "";
		//Longitud de la palabra elegida en cada caso
		public $longitud = 0;
		//Letras que se pueden usar como intento valido
		public $permitidos = " -abcdefghijklmnopqrstuvwxyz";
		public $letra = ' ';
		public $letraVacia = false;
		public $indicadorLetraPermitida = true;
		public $letrasIngresadas; //[]
		public $indicadorIntentos = false;
		public $indicadorLetraIn = false;
		
		//Cuando se comienza el juego
		function startGame()
		{
			if($this->primeraVez == true)
			{
				//Numero de intentos de usuario
				$this->intentos = -1;
				$contenido = file("palabras.txt");
				$linea_azar = $contenido[rand(0, count($contenido) - 1)];
				$linea_azar = trim($linea_azar);
				//Palabra dividida en letras escogida al azar de $contenido
				$this->palabraIngresada = $linea_azar;
				//No mostrar la respuesta a menos que se esten haciendo pruebas
				//echo $_SESSION['palabraingresada'];
				$this->longitud = strlen($this->palabraIngresada);
				$_POST['letra'] = ' '; //Importante!!!
				$this->primeraVez = false;
			}
		}
		
		//Devuelve hilera de '_' del tamano de la palabra escogida
		function hidden()
		{
			$ahorcado = $this->palabraIngresada;
			for ($i = 0; $i < $this->longitud; $i++){
				$ahorcado[$i] = '_';
			}
			$this->letra = ' ';
			return $ahorcado;
		}
		
		//Se verifica que el intento no sea vacio
		public function checkEmpty()
		{
			$this->letraVacia = false;
			if ($this->letra == ''){
				$this->letraVacia = true;
				$this->letra = '-';
				//Quitar echoes despues, no son necesarios para visual
				echo '<script type = "text/javascript">
					alert("DEBE INGRESAR UNA LETRA");            
				</script>';
			}
		}
		
		//Se verifica que el intento sea un caracter permitido
		function checkLetter()
		{
			$this->indicadorLetraPermitida = true;
			if (stripos($this->permitidos, $this->letra) === false){
				echo '<script type = "text/javascript">
					alert("La letra no es valida");            
				</script>';
				$this->indicadorLetraPermitida = false;
			}
		}
		
		//Verifica si ya se habia ingresado la letra antes
		function checkRepeated()
		{
			$contadorLetras = 0;   
			$this->indicadorLetraIn = false;
			if ($this->letra != ' '){
				for ($i=0; $i<count($this->LetrasIngresadas); $i++){
					if ($this->letrasIngresadas[$i] == $this->letra){            
						$contadorLetras ++;                
					}
				}        
				if ($contadorLetras >= 2){
					echo '<script type = "text/javascript">
					alert("La letra ya ha sido ingresada");            
				</script>';
					$this->indicadorLetraIn = true;
				}
			}
		}
		
		function checkAndReplace($ahorcado) //unINtento = la forma de asignar a letra el valor
		{
			$this->checkEmpty();
			$this->checkLetter();
			//Se guardan todas las letras ya utilizadas para evitar que sean repetidas
			if ($this->indicadorLetraPermitida == true && $this->letra != '-')
			{
				$this->LetrasIngresadas[] = $this->letra;
			}
			$this->indicadorIntentos = false;
			for ($i = 0; $i < $this->longitud; $i++)
			{
				if ($this->palabraIngresada[$i] == $this->letra)
				{
					$ahorcado[$i] = $this->letra;
					$this->indicadorIntentos = true;
				}
			}
			$this->checkRepeated();
			//Solo se cuenta como un intento si cumple con todas las reglas
			if ($this->indicadorIntentos == false && $this->indicadorLetraPermitida == true && 
				$this->indicadorLetraIn == false && $this->letraVacia == false)
			{
				$this->intentos++;
			}
			return $ahorcado;
		}
		
		function checkGameOver($ahorcado)
		{
			$aux = 0;
			for ($j=0; $j<$this->longitud; $j++){
				if ($this->palabraIngresada[$j] == $ahorcado[$j]){
					$aux++;
				}
			}    
			if ($aux == $this->longitud)
			{
				echo '<br>';
				?>
				<html>
					<p align="center">
					<!--Si se gana el juego se imprime la palabra encontrada-->
						<?php 
							for ($k=0; $k<$this->longitud; $k++){        
								echo $ahorcado[$k] . ' ';
							}
						?>
					</p>
				</html>
				<?php
				echo '<script type = "text/javascript">
					alert("FELICIDADES!! HA GANADO!!" echo $ahorcado);
				</script>';
				$this->mensajeJugarNuevamente();
			}
			
			//Se verifica si ha perdido el juego
			if ($this->intentos == 9){
				echo '<img src="imagenes/9.png">';
				sleep(0.5);
				echo '<br>';
				?>
				<html>
					<p align="center">
						<?php 
							for ($k=0; $k<$this->longitud; $k++){        
								echo $this->palabraIngresada[$k] . ' ';
							}
						?>
					</p>
				</html>
			<?php
				echo '<script type = "text/javascript">
					alert("HA PERDIDO");;
				</script>';
				$this->mensajeJugarNuevamente();
				}else{
					echo '<p align="center">Lleva ' . $this->intentos . '  intentos fallidos</p>';
				}
			?>
			<html>
				<p align="center">
					<?php 
						for ($k=0; $k<$this->longitud; $k++){        
							echo $ahorcado[$k] . ' ';
						}
					?>
				</p>
			</html>    
			<?php
		} //Fin de checkGameOver
		
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
	
	} //Fin de Hangman
?>