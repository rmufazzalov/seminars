# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

listdef = list(range(-1, 6))
print(listdef)
i = 0

while (i < (len(listdef) // 2)):
    print(listdef[i] * listdef[(len(listdef) - i) - 1])
    i += 1
if (len(listdef) % 2 != 0):
    print(listdef[len(listdef) // 2] ** 2)
