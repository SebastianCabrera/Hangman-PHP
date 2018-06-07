<?php
include 'classAhorcado.php';
$juego = new Ahorcado();
$juego->iniciarJuego();
echo $juego->getPalabra();
$palabraEscondida = $juego->palabraEscondida();
echo $palabraEscondida; //Imprime 'ahorcado'
echo "antes de verificar";
$palabraEscondida = $juego->verificarLetra('a', $palabraEscondida); 
echo $palabraEscondida; //Imprime 'ahorcado'
echo $juego->verificarResultadoDeJuego($palabraEscondida);
echo $juego->getIntentos();

?>