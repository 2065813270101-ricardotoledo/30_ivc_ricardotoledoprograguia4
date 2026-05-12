Algoritmo Lecc28Ins1
	Definir tipo,continuar Como Entero
	Definir total Como Real
	total=0
	continuar=1
	Mientras continuar=1 Hacer
		Escribir "Tipo de boleto"
		Escribir "1=Niño"
		Escribir "2=Adulto"
		Leer tipo
		Segun tipo Hacer
			1:
				total=total+10
			2:
				total=total+15
			De Otro Modo:
				Escribir "Opcion invalida"
		FinSegun
		Escribir "¿Desea ingresar otro boleto?(1=Si,0=No)"
		Leer continuar
	FinMientras
	Escribir "Total cobrado:$",total
FinAlgoritmo
