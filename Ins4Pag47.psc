Algoritmo Ins4Pag47
    Definir num, i Como Entero
    Definir primo Como Logico
    Escribir "NUMEROS PRIMOS"
    Escribir "Digite un numero entero:"
    Leer num
    primo = Verdadero
    Si num <= 1 Entonces
        primo = Falso
    SiNo
        Para i = 2 Hasta num - 1 Hacer
            Si num MOD i = 0 Entonces
                primo = Falso
            FinSi
        FinPara
    FinSi
    Si primo Entonces
        Escribir "Numero primo"
    SiNo
        Escribir "Numero no primo"
    FinSi
	FinAlgoritmo
