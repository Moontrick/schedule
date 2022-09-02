import asyncio
import requests
from lxml import etree
import lxml.html


url = "https://www.sgu.ru/schedule/knt/do/311"
api = requests.get(url)
tree = lxml.html.document_fromstring(api.text)
for i in range(6):
    for j in range(8):
        str1 = '//*[@id="' + str(j+1) + '_' + str(i+1)
        text_teg = tree.xpath(str1 + '"]/div/div[1]/div[2]/text()')
        print(text_teg)
        text_teg = tree.xpath(str1 + '"]/div/div[1]/div[3]/text()')
        print(text_teg)
        text_teg = tree.xpath(str1 + '"]/div/div[2]/text()')
        print(text_teg)
        text_teg = tree.xpath(str1 + '"]/div/div[3]/a/text()')
        print(text_teg)
        text_teg = tree.xpath(str1 + '"]/div/div[4]/text()')
        print(text_teg)


