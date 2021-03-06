# apbd-final-project
## Deadline: end of june</br>
- ### UI - 'front' branch
  #### main layout
    - [x] header
    - [x] footer 
  #### Pages
    - [x] sign in page
    - [x] sign up page
    - [x] reset password page
    - [x] dashboard page
    - [x] market page
    - [x] settings page
    - [ ] profile page
    - [ ] loading page

- ### API - 'back-end' branch
    - [x] auth
    - [x] registration
    - [ ] polygon.io api provider
    - [ ] crud operations for each entity
-----
#### Projektowana aplikacja SPA będzie wykorzystywać opisywane w czasie ćwiczeń technologie. Będzie to aplikacja typu SPA (ang. single-page application) wykorzystujące REST API, Blazor i bazę danych.
#### Aplikacja będzie nieco podobna do https://finance.yahoo.com
#### Np widok dostępny pod poniższym linkiem:
#### https://finance.yahoo.com/quote/TSLA?p=TSLA&.tsrc=fin-srch
-----
<b>Architektura aplikacji zaprezentowana jest poniżej.</b><br />
* Blazor application – aplikacja napisana z pomocą Blazer będzie reprezentować interfejs naszej aplikacji (tzw. „frontend”).<br />
* Web API – aplikacja typu REST API służy jako tzw. „backend”. Aplikacja komunikuje się z aplikacją frontendową Blazor, jak również zewnętrznym serwisem Polygon.ai i bazą danych.<br />
* Database server – baza danych MS SQL Server pozwalająca na zapisanie interesujących nas danych na temat użytkowników i spółek.<br />
* Polygon.ai – zewnętrzny serwis pozwalający uzyskać informacje na temat notowań spółek giełdowych.<br />
-----
<b>Nasz serwis będzie pozwalał na:</b><br />
1. Rejestracja i logowanie. Wszystkie funkcje dostępne są wyłącznie z poziomu zalogowanego użytkownika.<br />
2. Wyszukiwanie i wyświetlanie danych na temat wybranej spółki giełdowej – obejmując wykres OHLC – Open-High-Low-Close z wybranego zakresu dat.<br />
3. Dodanie spółki do listy spółek obserwowanych.<br />
