# Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.

m = int(input("Введите число: "))
multlist = []
while (m != 1):
    for i in list(range(2, int(m + 1))):
        if ((m % i) == 0):
            m = m / i
            multlist.append(i)
            break
print(set(multlist))
