print ("Finite state machine minimization")

print("Reading configuration file ...")
config = open('config.txt', 'r')

Nstates = int(config.readline())
print("Number of states is ", Nstates)

symbols = config.readline().rstrip().split(' ')
print("Input alphabet is ", symbols)

Flist = [int(x) for x in config.readline().rstrip().split(' ')]
favorable = [False]*(Nstates+1)
for x in Flist:
    favorable[x] = True
print("List of the favorable states (first item is unused): ", favorable)

StartingState = int(config.readline())
print("Starting state is ", StartingState)

rules = {}
pairs = {}

for line in config.readlines():
    temp = line.rstrip().split(' ')
    rules[str(temp[0]+temp[1])] = temp[2]

print("Machine rules are: ", rules)

for x in range(Nstates+1):
    if x == 0:
        continue
    for y in range(Nstates+1):
        if y == 0:
            continue
        mark = False
        if (favorable[x] == True and favorable[y] == False) or (favorable[y] == True and favorable[x] == False):
            mark = True
        pairs[str(x)+str(y)] = mark

print("Whole list of the pairs: ", pairs)

found = True

while found:
    
    found = False
    
    for key in pairs.keys():
        
        if key[0] == '0' or key[1] == '0':
            continue

        if not pairs[key]:
            for symbol in symbols:
                d1 = rules[key[0]+symbol]
                d2 = rules[key[1]+symbol]

                if pairs[d1+d2]:
                    pairs.update({key:True})
                    found = True
                    break
            else:
                continue
            break

print("Whole list of the pairs after marking: ", pairs)

e_class = [i for i in range(Nstates+1)]

for key in pairs.keys():

    if not pairs[key]:

        for i in range(Nstates+1):
            if i == 0 :
                continue
            if e_class[i] == int(key[0]):
                e_class[i] = int(key[1])

print(e_class)

print("States after minimization:")

StatePrinted = [False]*(Nstates+1)

for state in range(Nstates+1):
    if state == 0:
        continue
    if not StatePrinted[e_class[state]]:
        print(state," ")
        StatePrinted[e_class[state]] = True

RulesPrinted = {}

for rule in rules.keys():
    ruleString = "(" + str(e_class[int(rule[0])]) + ", " + rule[1] + ") -> " + str(e_class[int(rules[rule])])
    if not ruleString in RulesPrinted:
        print(ruleString)
        RulesPrinted[ruleString] = True
