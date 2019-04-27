# coding: utf-8
from selenium import webdriver
from random import randint
from time import sleep
import pickle
import os
import re
from bs4 import BeautifulSoup as bs
from time import sleep
from random import randint
from selenium import webdriver


options = webdriver.ChromeOptions()
chrome_options = webdriver.ChromeOptions()
chrome = webdriver.Chrome("C:\\programs\\chromedriver\\chromedriver.exe", chrome_options=chrome_options)


if os.path.exists("cookies_Y_EDY.pkl"):
    chrome.get("https://education.yandex.ru")
    cookies = pickle.load(open("cookies_Y_EDY.pkl", "rb"))
    for cookie in cookies:
        chrome.add_cookie(cookie)
    if len(cookies) > 0:
        print('cookies loaded')

        sleep(2)
        # reload with loaded cookies
        chrome.get("https://education.yandex.ru")
else:
    print("введи логин и пароль в браузере и нажмите enter")
    chrome.get("https://passport.yandex.ru/auth?origin=education&retpath=https%3A%2F%2Feducation.yandex.ru%2F%3Fadult_registration%3Dtrue%26from_passport%3Dtrue")
    aaa = input()
    pickle.dump(chrome.get_cookies(), open("cookies_Y_EDY.pkl", "wb"))

chrome.get("https://education.yandex.ru/lab/classes/66354/settings/") 
elems = chrome.find_elements_by_class_name('students__student-row')
for item in elems:
    name = item.find_element_by_class_name('students__table-student-name-span').text
    login = item.find_element_by_class_name('students__table-student-login').text
    code = item.find_element_by_class_name('students__table-school-code').text
    print(name, login, code)
