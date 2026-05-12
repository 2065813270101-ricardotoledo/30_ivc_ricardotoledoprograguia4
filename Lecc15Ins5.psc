Algoritmo Lecc15Ins5
	Definir num,i,contPrimos,sumaPares Como Entero
	Definir primo Como Logico
	contPrimos=0
	sumaPares=0
	Para num=300 Hasta 1 Con Paso -1 Hacer
		Si num MOD 2=0 Entonces
			sumaPares=sumaPares+num
		FinSi
		primo=Verdadero
		Si num<=1 Entonces
			primo=Falso
		SiNo
			Para i=2 Hasta num-1 Hacer
				Si num MOD i=0 Entonces
					primo=Falso
				FinSi
			FinPara
		FinSi
		Si primo Entonces
			contPrimos=contPrimos+1
		FinSi
	FinPara
	Escribir "Cantidad de numeros primos: ",contPrimos
	Escribir "Suma de numeros pares: ",sumaPares
FinAlgoritmo
