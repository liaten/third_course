import random as rnd

def fitness(such,N):
    f = 0
    for i in range(N):
        f+=such[i]
    return f

chromo = 30
predki = 20
li = [[rnd.randint(0,1) for i in range(chromo)] for j in range(predki)]
saved_li = []
fit = []
sum = 0
for such in li:
    result = fitness(such,chromo)
    sum+=result
    fit.append(result)
dolya = [such/sum for such in fit]
nak_dolya = [dolya[0]]
for i in range(predki-1):
    nak_dolya.append(nak_dolya[i]+dolya[i+1])
print(dolya)
print(nak_dolya)
rul_result = rnd.random()
saved_pos = 0
for i in range(predki-1):
    if(rul_result>nak_dolya[i] and rul_result<nak_dolya[i+1]):
        saved_pos = i
        break
print(rul_result, saved_pos)
saved_li.append(saved_pos)