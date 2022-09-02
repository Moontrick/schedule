

import asyncio
import requests
from lxml import etree
import lxml.html


url = "https://www.sgu.ru/schedule/knt/do/311"
api = requests.get(url)
tree = lxml.html.document_fromstring(api.text)
text_teg = tree.xpath('//*[@id="1_1"]/div/div[2]/text()')
print(text_teg)
text_teg = tree.xpath('//*[@id="1_1"]/div/div[3]/a/text()')
print(text_teg)
text_teg = tree.xpath('//*[@id="1_1"]/div/div[4]/text()')
print(text_teg)



