# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных позициях. Позиции хранятся в файле file.txt в одной строке одно число.(для продвинутых - с файлом, вариант минимум - ввести позиции в консоли)

path = 'hw2/file.txt'
data = open(path, 'r')
bufer = []
for line in data:
    bufer.append(int(line))
data.close()

posstr = input("Какие позици перемножить(через пробел): ")
poslist = posstr.split()
a = int(poslist[0])
b = int(poslist[1])
print(bufer[a]*bufer[b])
