# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

#listdef = list(range(-1, 6))
listdef = [i for i in range(-4, 19)]
print(listdef)
i = 0


def mult(f, x, y):
    print(f(x, y))


def multmid(f, z):
    print(f(z))


while (i < (len(listdef) // 2)):
    #print(listdef[i] * listdef[(len(listdef) - i) - 1])
    mult(lambda x, y: x * y,
         listdef[i], listdef[(len(listdef) - i) - 1])
    i += 1
if (len(listdef) % 2 != 0):
    #print(listdef[len(listdef) // 2] ** 2)
    multmid(lambda z: z ** 2, listdef[len(listdef) // 2])
