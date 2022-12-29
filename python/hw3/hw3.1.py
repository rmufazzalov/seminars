# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

#listdef = list(range(-4, 19))
listdef = [i for i in range(-4, 19)]
print(listdef)
i = 0
sum = 0


for y in listdef:
    if (i % 2 != 0):
        sum += listdef[i]
    i += 1
print(sum)
