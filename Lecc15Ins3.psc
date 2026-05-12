Algoritmo Lecc16Ins3
	Definir billete,i,cont100,total Como Entero
	cont100=0
	total=0
	Para i=1 Hasta 1000 Hacer
		Escribir "Ingrese denominacion del billete:"
		Leer billete
		total<-total+billete
		Si billete=100 Entonces
			cont100<-cont100+1
		FinSi
	FinPara
	
	Escribir "Cantidad de billetes de 100: ",cont100
	Escribir "Dinero total: ",total

FinAlgoritmo
