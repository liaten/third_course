from pymorphy2 import MorphAnalyzer
from wikipedia import search
from spacy import load
doc = load("ru_core_news_lg")(input())
for word in doc:
  if word.pos_ == 'NOUN':
    noun = word.text
    if(str(MorphAnalyzer().parse(noun)[0].tag).split(',')[0]=='NOUN'):
      print(MorphAnalyzer().parse(noun)[0].normal_form,search(MorphAnalyzer().parse(noun)[0].normal_form))