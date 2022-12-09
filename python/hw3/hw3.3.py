# Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

listdef = [1.34, 0.723, 4.5, 7.1238, 34.32451]
print(listdef)
listfract = []
for i in listdef:
    listfract.append(round((i - int(i)), 5))
listfract.sort()
listmin = listfract[0]
listmax = listfract[-1]
print(f'{listmax} - {listmin} = {listmax - listmin}')
