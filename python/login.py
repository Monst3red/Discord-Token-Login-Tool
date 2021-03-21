import selenium
from selenium import webdriver

token = input("Token here: ")

script = '''
    const login = (token) => {
        setInterval(() => document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage.token = `"${token}"`, 50);
        setTimeout(() => location.reload(), 2500);
    };''' + f'login("{token}")'

driver = webdriver.Chrome("chromedriver.exe")
driver.get("https://discord.com/login")
driver.execute_script(script)