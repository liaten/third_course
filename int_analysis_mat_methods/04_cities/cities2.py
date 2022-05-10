with open ('cities8000.txt','r') as f:
    lines = [line.rstrip('\n') for line in f]
    new_lines = []
    for line in lines:
        s = line.split(';')
        new_s = s[1] + ' ' + s[2]
        new_lines.append(new_s)
    dup = []
    for c in set(new_lines):
        if(new_lines.count(c)>1):
            dup.append(c)
    print('Количество повторений:',len(dup),'\nСписок повторений:',dup)