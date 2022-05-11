from pymorphy2 import MorphAnalyzer
from wikipedia import search
userInput = input()
words = userInput.split()
morph = MorphAnalyzer()
for word in words:
    p = morph.parse(word)[0]
    s = str(p.tag)
    lst = s.split(',')
    if(lst[0]=='NOUN'):
        result = search(word)
        print(word,result)