Stworzona aplikacja umo¿liwia zapisywanie danych klienta i parametrów zamówienia do bazy danych oraz pliku XML.
Klikaj¹c "Zapisz do bazy danych" zapisany zostaje aktualnie wyswietlany klient oraz jego zamówienia,
Klikaj¹c "Zapisz do XML" zapisany zostaje stan bazy danych do pliku XML dostêpny w folderze .\DataBaseDemo\bin\debug\*.xml
Klikaj¹c przycisk dodaj produkt, usuñ produkt, zmieñ produkt odpowiednio zostaje dodany produkt widoczny w kontrolce DataGridView.
Nie mo¿na dodawaæ dwóch takich samych produktów, jak równie¿ nie mo¿na dodawaæ produktu w momencie, gdy nie s¹ uzupe³nione wszystkie
dane klienta oraz produktu.
Sama baza danych zosta³a umieszczona w "rozwi¹zaniu" dlatego po ka¿dym uruchomieniu zostaje ona nadpisana
do folderu wynikowego .\DataBaseDemo\bin\debug\
W momencie uruchomienia programu stan bazy danych zostaje skopiowany do pamiêci programu. Proces ten odbywa siê w klasie CustomerCollections.cs
Zmieniaj¹c imiê, nazwisko lub datê urodzenia, program automatycznie szuka czy dany u¿ytkownik istnieje w pamiêci programu, je¿eli tak, 
to zostaje wyœwietlona jego lista zamówienia
