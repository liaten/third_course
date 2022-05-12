from pymorphy2 import MorphAnalyzer
from wikipedia import search
from spacy import load
for word in load("ru_core_news_lg")(input()):
  if word.pos_ == 'NOUN':
    noun = MorphAnalyzer().parse(word.text)[0].normal_form
    print(noun,search(noun))
