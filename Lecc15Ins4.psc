Algoritmo Lecc15Ins4
	Definir i,mul,suma,pares Como Entero
	suma=0
	pares=0
	Para i=1 Hasta 20 Hacer
		mul=7*i
		suma=suma+mul
		Si mul MOD 2=0 Entonces
			pares=pares+1
		FinSi
	FinPara
	Escribir "Sumatoria: ",suma
	Escribir "Cantidad de pares: ",pares
FinAlgoritmo
