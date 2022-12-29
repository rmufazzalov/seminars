# Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.

path1 = "hw4/1.txt"
path2 = "hw4/2.txt"

data = open(path1, 'r')
for line1 in data:
    print(line1)
data.close

data = open(path2, 'r')
for line2 in data:
    print(line2)
data.close

listobj1 = list(line1)
listobj2 = list(line2)
listobj3 = []

i = 0
for letter in listobj1:
    if (('0' <= letter) and (letter <= '9')):
        listobj3.append(int(listobj1[i]) + int(listobj2[i]))
    else:
        listobj3.append(letter)
    i += 1


rezultstr = ''
for y in listobj3:
    rezultstr += str(y)

with open('hw4/rez.txt', 'w') as data:
    data.write(rezultstr)
