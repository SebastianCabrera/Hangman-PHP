<?php
  
require_once 'classAhorcado.php';
 
if (isset($_GET['wsdl'])) {
	header('Content-Type: application/soap+xml; charset=utf-8');
	echo file_get_contents('Ahorcado.wsdl');
}
else {
	session_start();
	$servidorSoap = new SoapServer('http://titanic.ecci.ucr.ac.cr:80/~eb41188/Ahorcado/?wsdl');

	//Para evitar la excepción por defecto de SOAP PHP cuando no existe HTTP_RAW_POST_DATA,
	//se regresa explícitamente el siguiente fallo cuando no hay solicitud (v.b. desde un navegador)
	if(!@$HTTP_RAW_POST_DATA){
		$servidorSoap->fault('SOAP-ENV:Client', 'Invalid Request');
		exit;
	}

	$servidorSoap->setClass('Ahorcado');
	$servidorSoap->setPersistence(SOAP_PERSISTENCE_SESSION);
	$servidorSoap->handle();
}

?>