with open ('cities.txt','r',encoding='utf-8') as f:
    lines = [line.rstrip('\n') for line in f]
    dup = []
    for c in set(lines):
        if(lines.count(c)>1):
            dup.append(c)
    print('Количество повторений:',len(dup),'\nСписок повторений:',dup)