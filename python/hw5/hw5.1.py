import random
kandy = 117
maxNum = 28
player1 = input("Введите имя игрока1: ")
player2 = input("Введите имя игрока2, для игры против бота введите bot: ")
player = player1
while (kandy > 0):
    if (player != "bot"):
        a = int(input(f'Игрок {player} введите цифру не больше 28: '))
    else:
        if (kandy < 28):
            maxNum = kandy
        a = random.randrange(1, maxNum)
        print(f'bot отнимает {a} конфет')
    if (a <= maxNum):
        kandy -= a
        print(f'Осталось {kandy} конфет')
        if (kandy < 1):
            continue
        if (player != player1):
            player = player1
        else:
            player = player2
    else:
        print(f'Не больше оставшихся {kandy} конфет')
print(f'Игрок {player} выйграл')
