# Практическая работа №6.3 - Создание автоматизированных Unit-тестов

### Дисциплина: МДК.01.02 Поддержка и тестирование программных модулей

### Цель работы: провести тестирование разработанных программных модулей
с использованием средств автоматизации Microsoft Visual Studio методом белого ящика.

### Разработчики: 
Глушков Артём (3ИСИП-523) <br>
Сидоров Дмитрий (3ИСИП-523)

---

### Дальнейшие скриншоты представят таблицу с пользователями из СУБД, а также результаты из "Обозревателя тестов"

№1 Таблица данных пользователей: <br>
<img width="491" height="337" alt="image" src="https://github.com/user-attachments/assets/208a81d7-1b74-4870-be3f-02098d925be3" /> <br>

№2 Результаты тестирования авторизации и регистрации: <br>
<img width="1280" height="321" alt="image" src="https://github.com/user-attachments/assets/37ff0a5d-9fb3-4ac8-b1b1-1675310b7226" /> <br>

---
### Вывод о проведенном тестировании

#### Тест №1: Общая работа метода авторизации
Наборы вводных данных:
  * ("bebe", "baba")
  * ("user1", "12345")
  * ("","")
  * (" ", " ") <br>
  
Ожидаемый результат: Первый набор данных должен успешно авторизоваться, остальные же вывести ошибку <br>
Результат: Тест выполнен успешно <br>

#### Тест №2: Работа позитивных сценариев метода авторизации
Наборы вводных данных:
  * ("bebe", "baba")
  * ("pepe", "shn")
  * ("GOREdov", "1467")
  * ("user", "12435")
  * ("Yli@gmai.com", "GwffgE")
  * ("Vladlena@gmai.com", "yntiRS") <br>
  
Ожидаемый результат: Успешная авторизация каждого из набора данных <br>
Результат: Тест выполнен успешно <br>

#### Тест №3: Работу негативных сценариев метода авторизации
Наборы вводных данных:
  * ("", "")
  * ("Yli@gmai.com", "12345")
  * ("1234@gail.com", "GwffgE")
  * ("Yli@gmai.com", "YNTIRS")
  * ("' OR 1=1 –", "Vladlena@gmai.com'; DROP TABLE users;--") <br>
  
Ожидаемый результат: Вывод ошибки при авторизации по наборам данных <br>
Результат: Тест выполнен успешно <br>

#### Тест №4: Работа позитивных сценариев метода регистрации
Наборы вводных данных:
  * (page.Registration("Vasilisa@gmai.com", "d7iKKV56", "d7iKKV56") <br>
  
Ожидаемый результат: Успешная регистрация набора данных <br>
Результат: Тест выполнен успешно <br>


#### Тест №5: Работу отрицательных сценариев метода регистрации
Наборы вводных данных:
  * ("Yli@gmai.com", "GwffgE", "GwffgE")
  * ("Testmail298@gmail.com", "12121212", "11111111")
  * ("", "", "")
  * ("' OR 1=1 –", "Vladlena@gmai.com'; DROP TABLE users;--", "Vladlena@gmai.com'; DROP TABLE users;--")
  * ("Bebabeba@gmail.com", "1234567", "1234567")
  * (page.Registration("Bebabeba@gmail.com",                "tetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetoteto",              "tetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetotetoteto") <br>
  
Ожидаемый результат: Вывод ошибки при регистрации по наборам данных по разным условиям <br>
Результат: Тест выполнен успешно <br>

---
### SQL-скрипт базы данных
[Cinema14.sql](https://github.com/user-attachments/files/26389244/Cinema14.sql)
