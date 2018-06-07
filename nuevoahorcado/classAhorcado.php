<?php

  class Ahorcado{
	  public $intentos;
	  public $palabra;
	  public $letra;
	  public $ahorcado;
	  public $longitud;
	  public $permitidos;
	  
	  function __construct(){
		  $this->intentos=0;
		  $this->palabra ='verde';
		  $this->letra='';
		  $this->ahorcado;
		  $this->longitud='';
		  $this->permitidos = " -abscdefghijklmnopqrstuvwxyz";

	  }
	  function inciarJuego(){
		  $contenido = file("palabras.txt");
			$linea_azar = $contenido[rand(0, count($contenido) - 1)];
			$linea_azar = trim($linea_azar);
			$this->palabra= $linea_azar;
			$this->longitud= strlen($this->palabra);
			for ($i = 0; $i < $this->longitud; $i++){
				$this->ahorcado[$i] = '_';
			}
			
	  }
	  
	  function mostrarAhorcado(){
		  echo $this->palabra;
		  echo '<br>';
		  for ($i = 0; $i < $this->longitud; $i++){
				echo $this->ahorcado[$i];
		   }
		   echo '<br>';
		   echo '<br>';
		  echo $this->longitud;
		   echo '<br>';
		   echo 'intentos '.$this->intentos;
	  }
	  
	  function verificarLetra($l){
		$indicadorIntentos=false;  
		$this->letra= $l;
		for ($i = 0; $i < $this->longitud; $i++){
			if ($this->palabra[$i] == $this->letra){
				$this->ahorcado[$i] = $this->letra;
				$indicadorIntentos = true;
			}
		}
		if(indicadorIntentos==false){
			$this->intentos++;
	    }
		return indicadorIntentos;
		echo 'resultado';
      }
	  
	  
	  
	  
	  
	 	  
  }  

?>