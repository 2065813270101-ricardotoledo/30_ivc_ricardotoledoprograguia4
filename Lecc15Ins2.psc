Algoritmo Lecc15Ins2
    Definir num, i, contador, suma Como Entero
    Definir primo Como Logico
    contador = 0
    suma = 0
    Para num = 1 Hasta 100 Hacer
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
            contador = contador + 1
            suma = suma + num
        FinSi
    FinPara
    Escribir "Cantidad de numeros primos: ", contador
    Escribir "Suma de los numeros primos: ", suma
FinAlgoritmo
