<?php session_start();?>
<html>
	<head>
		<title>The Hangman</title>
	</head>
	
	<body>
		<?php
			include 'config.php';
			include 'funciones.php';
			if(isset($_SESSION['newWord'])) //Se pide una nueva palabra
			{
				unset($_SESSION['answer']);
			}
			if(!isset($_SESSION['answer'])) //Se esta comenzando el juego
			{
				$_SESSION['attempts']=0;
				$answer = fetchWordArray($WORLDLISTFILE); //Guarda la palabra dividida en letras
				$_SESSION['answer'] = $answer;
				$_SESSION['hidden'] = hide_characters($answer); //Es el string con los espacios en blanco ----
				echo 'Attempts remaining: '.($MAX_ATTEMPS-$_SESSION['attempts']).'<br>';
			}
			else
			{
				if(isset($POST['userInput'])) //Si el usuario ha hecho un intento
				{
					$userInput = $_POST['userInput'];
					//Se revisa si el valor ingresado es correcto
					$_SESSION['hidden'] = checkAndReplace(strtolower($userInput), $_SESSION['hidden'], $_SESSION['answer']);
					checkGameOver($MAX_ATTEMPS, $_SESSION['attempts'], $_SESSION['answer'], $_SESSION['hidden']);
				}
				$_SESSION['attempts'] = $_SESSION['attempts'] +1;
				echo 'Attempts remaining: '.($MAX_ATTEMPS-$_SESSION['attempts']).'<br>';
			}
			echo '<br>';
			$hidden = $_SESSION['hidden'];
			
			foreach($hidden as $char)
			{
				echo $char." ";
			}
		?>
		
		<script type="application/javascript">
			function validateInput()
			{
				var x = document.forms["inputForm"]["userInput"].value;
				if(x=="" || x==" ")
				{
					alert("Please entre a character");
					return false;
				}
				if(!isNan(x))
				{
					alert("Please entre a character");
					return false;
				}
			}
		</script>
		
		<form name="inputForm" action="" method="post">
			Your Guess: <input name="userInput" type="text" size="1" maxlength="1">
			<input type="submit" value="Check" onClick="return validateInput();">
			<input type="submit" value="Try Another Word" name="newWord" value="submit">
		</form>
		
	</body>
	
</html>