import asyncio
import requests
import soupsieve.css_parser
from bs4 import BeautifulSoup

url = "https://www.sgu.ru/schedule/knt/do/311"
api = requests.get(url)

html = BeautifulSoup(api.text, 'html.parser')


for i in range(6):
    for j in range(8):
        teme = html.find("td", id=str(j+1) + '_' + str(i+1))
        name = teme.find("div", class_="l-pr-r")
        if name is None:
            name = 'No type'
        else:
            print(name.text)
        name = teme.find("div", class_="l-pr-t")
        if name is None:
            name = 'No type'
        else:
            print(name.text)
        name = teme.find("div", class_="l-dn")
        if name is None:
            name = 'No type'
        else:
            print(name.text)
        name = teme.find("div", class_="l-tn")
        if name is None:
            name = 'No type'
        else:
            print(name.text)
        name = teme.find("div", class_="l-p")
        if name is None:
            name = 'No type'
        else:
            print(name.text)





