Algoritmo Lecc15Ins1
	Definir adultos, ninos, totalBoletos Como Entero
    Definir totalDinero Como Real
    Escribir "Cantidad de boletos para adultos:"
    Leer adultos
    Escribir "Cantidad de boletos para ninos:"
    Leer ninos
    totalBoletos = adultos + ninos
    totalDinero = (adultos * 15) + (ninos * 10)
    Escribir "Total de boletos vendidos: ", totalBoletos
    Escribir "Total de dinero recaudado: $", totalDinero
FinAlgoritmo
