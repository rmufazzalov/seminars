# Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.(Дополнительно)

fib1 = 1
fib2 = 1

n = int(input("Номер элемента ряда Негафибоначчи: "))
if (n < 0):
    k = -1
else:
    k = 1
n *= k
i = 0
def calc(x, y, z): return x + y * z


while i < n - 2:
    #fib_sum = fib1 + fib2 * k
    fib_sum = calc(fib1, fib2, k)
    fib1 = fib2
    fib2 = fib_sum
    i += 1

print(f'Значение этого элемента: {fib2}')
