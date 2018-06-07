<?php

$juego = new Ahorcado();
$juego->iniciarJuego();
echo $juego->verificarLetra('a'); //Imprime 'ahorcado'
echo $juego->verificarResultadoDeJuego();
echo $juego->mostrarAhorcado();
echo $juego->getIntentos();

?>