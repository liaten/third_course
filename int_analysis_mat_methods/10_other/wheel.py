import random as rnd
from itertools import accumulate 
N = 5

dia = [0,0,0,0,0]
wheel = [0.3,0.25,0.1,0.15,0.2]
wheel_s = list(accumulate(wheel))
print(wheel, wheel_s)
for sss in range (0,10000000):
    
    case = rnd.uniform(0.00001,0.99999)
    #print(case)
    for j in range(0,5):
        if case < wheel_s[j]:
            k = j
            dia[k] += 1
            break
#print(k, dia[k])
print(dia)

    
    

