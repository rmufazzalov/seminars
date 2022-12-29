# Задайте список из n чисел последовательности(1+1/n) ^ n и выведите на экран их сумму.

#n = int(input("Введите целое число: ")) + 1
n = 5
rezult = 0
# for i in range(1, n):
#     rezult = (1 + 1/i)**i
#     print(round(rezult, 3))

rezlist = [round((1 + 1/i)**i, 3) for i in range(1, n)]
print(rezlist)
