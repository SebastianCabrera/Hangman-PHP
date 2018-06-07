<?php

class Ahorcado{
	//numero de intentos
	public $intentos;
	//La palabra escogida para adivinar
	public $palabra;
	//Letra escogida por el usuario en cada intento
	public $letra;
	//Palabra escondida que se va revelando poco a poco
	//public $ahorcado;
	//Longitud de 'palabra'
	public $longitud;
	//Caracteres que estan permitidos como intento del usuario
	public $permitidos;
	//Lista de letras ingresadas para evitar que se repitan
	public $letrasIngresadas;
	//Define si el juego termino
	public $finDelJuego;

	function __construct()
	{
		//SESSION
		$this->intentos=0;
		$this->palabra ='verde'; 
		$this->letra='';
		$this->ahorcado;
		$this->longitud=0;
		$this->permitidos = " -abscdefghijklmnopqrstuvwxyz";
		$this->letrasIngresadas = array();
		$this->finDelJuego = false;
	}
	
	function iniciarJuego()
	{
		$contenido = file("palabras.txt");
		$linea_azar = $contenido[rand(0, count($contenido) - 1)];
		$linea_azar = trim($linea_azar);
		//Palabra elegida
		$this->palabra= $linea_azar;
		$this->longitud= strlen($this->palabra);
		//$_POST['letra'] = '';
		//$_SESSION['primeravez'] = false;
	}
	
	//Devuelve la palabra escondida inicial
	function palabraEscondida()
	{
		$ahorcado = array();
		for ($i = 0; $i < $this->longitud; $i++){
			$this->ahorcado[$i] = '_';
		}
		return $ahorcado;
	}

	function verificarLetra($l, $ahorcado)
	{
		$indicadorIntentos=false;  
		$this->letra= $l;
		
		//La letra se agrega a la lista de repetidas si no se habia usado
		$checkRepetido2 = true;
		if ($this->checkRepeated() == false && $this->letra != '-')
		{
			$this->letrasIngresadas[] = $this->letra;
			$checkRepetido2 = false;
		}
		
		//coloca letras en ahorcado
		for ($i = 0; $i < $this->longitud; $i++){
			if ($this->palabra[$i] == $this->letra)
			{
				$ahorcado[$i] = $this->letra;
				$indicadorIntentos = true;
			}
		}
		
		if(	$checkRepetido2 == false && $indicadorIntentos==true && !checkEmpty() && 
			checkLetter()  && $this->letra != '-')
		{
			$this->intentos++;
		}
		
		/*
		if(indicadorIntentos==false){ //No seria true?
			$this->intentos++;
		}
		*/
		return $ahorcado;
	}
	
	function getIntentos()
	{
		return 'Lleva '.$this->intentos;
	}
	
	function algo()
	{
		<?php 
					for ($k=0; $k<$this->longitud; $k++){        
						echo $this->ahorcado[$k] . ' ';
					}
				?>
				
				$mensajeRetorno = 'Lleva '  .  $this->intentos . '  intentos';
	}
	
	function verificarResultadoDeJuego($ahorcado)
	{
		//Este mensaje va a ser una oracion si termino el juego
		//y la cantidad de intentos que ha hecho si no 
		$mensajeRetorno = '';
		$aux = 0;
		for ($j=0; $j<$this->longitud; $j++)
		{
			if ($this->palabra[$j] == $ahorcado[$j])
			{
				$aux++;
			}
		}
		if ($aux == $this->longitud)
		{
			for ($k=0; $k<$this->longitud; $k++)
			{        
				echo $this->ahorcado[$k] . ' ';
			}
			$mensajeRetorno = "Felicidades";
			$this->finDelJuego = true;
		}
		
		//Se verifica si ha perdido el juego
		if ($this->intentos == 9)
		{
			for ($k=0; $k<$this->longitud; $k++){        
				echo $this->palabra[$k] . ' ';
			}
			$mensajeRetorno = "Perdiste";
			$this->finDelJuego = true;
		}
	} //Fin de checkGameOver
	  
	
	//Se verifica que el intento no sea vacio
	public function checkEmpty()
	{
		$letraVacia = false;
		if ($this->letra == ''){
			$this->letraVacia = true;
			$this->letra = '-';
			//Quitar echoes despues, no son necesarios para visual
			/*
			echo '<script type = "text/javascript">
				alert("DEBE INGRESAR UNA LETRA");            
			</script>';
			*/
		}
		return $letraVacia; //Debe ser false
	}
	
	//Se verifica que el intento sea un caracter permitido
	function checkLetter()
	{
		$indicadorLetraPermitida = true;
		if (stripos($this->permitidos, $this->letra) === false){
			$indicadorLetraPermitida = false;
		}
		return $indicadorLetraPermitida; //Debe ser true
	}
	
	//Verifica si ya se habia ingresado la letra antes
	function checkRepeated()
	{
		$contadorLetras = 0;   
		$indicadorLetraIn = false;
		if ($this->letra != ' '){
			for ($i=0; $i<count($this->letrasIngresadas); $i++){
				if ($this->letrasIngresadas[$i] == $this->letra){            
					$contadorLetras ++;                
				}
			}        
			if ($contadorLetras >= 2){
				$this->indicadorLetraIn = true;
			}
		}
		return $indicadorLetraIn; //Debe ser false
	}
	
	
	  
	function getfinDelJuego()
	{
		return $this->finDelJuego;
	}	  
}  
