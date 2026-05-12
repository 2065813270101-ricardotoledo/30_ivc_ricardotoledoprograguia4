Algoritmo Ins5Pag47
	Definir num Como Entero
	num = 1
	Escribir "Digame un numero para mostrar la tabla"
	leer num 
	Si num<0 Entonces
		Escribir  "ERROR"
	SiNo
		Para i = 1 Hasta 10 Con Paso 1 Hacer
			Escribir num, " x ", i, " = ", num * i
		FinPara
	Fin Si
FinAlgoritmo
