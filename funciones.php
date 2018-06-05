<?php
class Ahorcado {
	
	$MAX_ATTEMPS = 7;
	$WORLDLISTFILE = "worldlist.txt"

	//Variables globales que se vana utilizar
	$answer;
	$userInput;
	$userAttempts;
	
	//No estoy seguro si hidden necesita ser variable global
	//$hidden 
	
	//Comienza el juego
	function __construct()
	{
		$file = fopen($wordFile, "r"); //Abre el txt con las palabras
		if($file)
		{
			$random_line = null;
			$line = null;
			$count = 0;
			while(($line = fgets($file)) != false) //Lee el txt
			{
				$count++;
				if((rand() % $count) == 0) //Elige una palabra al azar de la lista
				{
					$random_line = trim($line); //Quita los espacios si hay
				}
			}
			if(!feof($file))
			{
				fclose($file);
				return null;
			}
			else
			{
				fclose($file);
			}
		}
		$this->answer = str_split($random_line); //Divide la palabra escogida en letras
		
	}
	
	//Utiliza: $answer
	//Devuelve una sucesion de '_' del mismo tamano que la palabra escogida
	function hide_characters()
	{
		$hidden = $answer;
		$count = 0;
		
		while($count != sizeof($answer))
		{
			$hidden[$count] = '_';
			$count++;
		}
		return $hidden; 
	}
	
	//Utiliza: $userInput, $hidden, $answer
	//Revisa si la letra que haya ingresado el usuario 
	//es valida, y modifica $hidden segun esto
	function checkAndReplace() 
	{
		$i = 0;
		$wrongGuess = true;
		while($i < count($answer))
		{
			if($answer[$i] == $userInput) //Se verifica si la letra que ingresó el usuario es correcta
			{
				$hidden[$i] = $userInput;
				$wrongGuess = false;				
			}
			$i = $i+1;
		}
		if(!$wrongGuess)
		{
			$_SESSION['attempts'] = $_SESSION['attempts']-1; //Si no lo es disminuye la cantidad de intentos
		}
		return $hidden;
	}
	
	//Utiliza $MAX_ATTEMPTS, $userAttempts, $answer, $hidden
	//Revisa si el juego se terminó, si ganó o perdió
	function checkGameOver()
	{
		if($userAttempts >= $MAX_ATTEMPTS) //Superó la cantidad maxima de intentos
		{
			//echo 'Game Over: The correct word was ';
			$word = '';
			foreach($answer as $letter)
			{
				$word += $letter;
			}
			//echo '<br><form action="" method="post"><input type="submit" name="newWord" value="Try Another Word"></form><br>';
			$this->attempts = 0;
			return (false, $word);
		}
		if($hidden==$answer)
		{
			echo 'Congratulations: The correct word was indeed';
			foreach($answer as $letter)
			{
				echo $letter;
			}
			echo '<br><form action="" method="post"><input type="submit" name="newWord" value="Try Another Word"></form><br>';
			$_SESSION['attempts'] = 0;
			die;
		}
	}
	
?>