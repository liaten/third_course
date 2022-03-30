from warnings import catch_warnings
from openpyxl import load_workbook
print("Программа возвращает вероятность события относительно 4 признаков.")
print("Выберите признаки:")
obl = 0
obl_y=-1
temp = 0
temp_y=-1
vlazh = 0
vlazh_y=-1
vet = 0
vet_y=-1
while 1:
    try:
        obl = int(input("Облачность: (1) - солнечно (2) - пасмурно (3) - дождь\n:"))
        if(obl in range(1,4)):
            try:
                obl_y = int(input("(0) - нет (1) - да\n:"))
                if obl_y in range(0,2):
                    print(obl)
                    print(bool(obl_y))
                    break
            except ValueError:
                continue
    except ValueError:
        continue
while 1:
    try:
        temp = int(input("Температура: (1) - жарко (2) - тепло (3) - прохладно\n:"))
        if(temp in range(1,4)):
            break
    except ValueError:
        continue
while 1:
    try:
        vlazh = int(input("Влажность: (1) - нормальная (2) - высокая\n:"))
        if(vlazh in range(1,3)):
            break
    except ValueError:
        continue
while 1:
    try:
        vet = int(input("Ветер: (1) - умеренный (2) - сильный\n:"))
        if(vet in range(1,3)):
            break
    except ValueError:
        continue
wb = load_workbook(filename = 'bayes.xlsx')
init = wb['вероятности']
#TODO: вычисление вероятности
wb.save('bayes.xlsx')