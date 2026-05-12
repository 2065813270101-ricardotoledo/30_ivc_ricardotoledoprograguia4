Algoritmo Inciso2Pag45
	Definir monedas Como Real
	monedas=0
	Escribir "Digite la cantidad de monedas que tiene:"
	Escribir "Necesita 350 monedas para el siguiente nivel"
	leer monedas
	Si monedas = 350 Entonces
		Escribir "Puede pasar al siguiente nivel" 
	SiNo
		Escribir "faltan " , monedas-350 " monedas"
	Fin Si
FinAlgoritmo
