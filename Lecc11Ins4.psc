Algoritmo Lecc11Ins3
    Definir num1, num2, menor, mayor, i Como Entero
    Escribir "Digite el primer numero:"
    Leer num1
    Escribir "Digite el segundo numero:"
    Leer num2
    Si num1 < num2 Entonces
        menor <- num1
        mayor <- num2
    SiNo
        menor <- num2
        mayor <- num1
    FinSi
    Escribir "Multiplos de 4 comprendidos entre ", menor, " y ", mayor
    Para i = menor Hasta mayor Hacer
        Si i MOD 4 = 0 Entonces
            Escribir i
        FinSi
    FinPara	
FinAlgoritmo
