Stworzona aplikacja umo�liwia zapisywanie danych klienta i parametr�w zam�wienia do bazy danych oraz pliku XML.
Klikaj�c "Zapisz do bazy danych" zapisany zostaje aktualnie wyswietlany klient oraz jego zam�wienia,
Klikaj�c "Zapisz do XML" zapisany zostaje stan bazy danych do pliku XML dost�pny w folderze .\DataBaseDemo\bin\debug\*.xml
Klikaj�c przycisk dodaj produkt, usu� produkt, zmie� produkt odpowiednio zostaje dodany produkt widoczny w kontrolce DataGridView.
Nie mo�na dodawa� dw�ch takich samych produkt�w, jak r�wnie� nie mo�na dodawa� produktu w momencie, gdy nie s� uzupe�nione wszystkie
dane klienta oraz produktu.
Sama baza danych zosta�a umieszczona w "rozwi�zaniu" dlatego po ka�dym uruchomieniu zostaje ona nadpisana
do folderu wynikowego .\DataBaseDemo\bin\debug\
W momencie uruchomienia programu stan bazy danych zostaje skopiowany do pami�ci programu. Proces ten odbywa si� w klasie CustomerCollections.cs
Zmieniaj�c imi�, nazwisko lub dat� urodzenia, program automatycznie szuka czy dany u�ytkownik istnieje w pami�ci programu, je�eli tak, 
to zostaje wy�wietlona jego lista zam�wienia
