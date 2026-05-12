Algoritmo Lecc10Ins3
    Definir num, i, suma Como Entero
    Definir primo Como Logico
    suma = 0
    Para num = 1 Hasta 22 Hacer
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
            suma = suma + num
        FinSi
    FinPara
    Escribir "La suma de los numeros primos es: ", suma
FinAlgoritmo
