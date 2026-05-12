Algoritmo Ins3Pag47
	Definir num, i Como Entero
	num = 0
	Escribir  "numeros impares entre 20"
	Leer num
	Mientras num>20 Hacer
		Escribir "Dime el numero: "
	Fin Mientras
	Si (num % 2 = 0) Entonces
		Para i = num + 1 Hasta 20 Con Paso 2 Hacer
			Escribir i
		FinPara
	SiNo
		Para i = num Hasta 20 Con Paso 2 Hacer
			Escribir i
		FinPara
	Fin Si
FinAlgoritmo
