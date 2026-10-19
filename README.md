# BorrowCar

Edukacyjna aplikacja konsolowa w C# wykorzystująca programowanie obiektowe do przechowywania danych samochodów i obliczania spalania.

## Funkcje

- Pobieranie danych trzech samochodów: marka, model, rok produkcji, przebieg, dystans i zużyte paliwo.
- Przechowywanie obiektów w `List<Samochod>`.
- Wyświetlanie informacji i spalania każdego pojazdu.
- Wskazanie najmniejszego spalania.
- Wyświetlanie samochodów spalających mniej niż 6,5 l/100 km.

## Budowa

Klasa `Samochod` łączy dane z metodami `ObliczSpalanie()`, `WyswietlInformacje()` i `CzyEkonomiczny()`.

## Uruchomienie

Wymagany .NET SDK 8.0. W katalogu projektu wykonaj:

```bash
dotnet run
```

Liczby dziesiętne wpisuj z przecinkiem, np. `6,2`.

## Przykład

Dla dystansu 100 km i zużycia paliwa 6,2 / 7,1 / 5,9 l spalanie wynosi odpowiednio 6,20 / 7,10 / 5,90 l/100 km. Najbardziej ekonomiczny jest trzeci samochód. Pierwszy i trzeci spełniają próg ekonomiczności.

## Zakres

Projekt ćwiczy klasy, obiekty, metody i listy. Nie obsługuje rezerwacji ani wynajmu. Dane istnieją tylko podczas działania programu.

Wczytywanie liczb zakłada poprawny format; tekst zamiast liczby może spowodować wyjątek. Program sprawdza dodatni dystans i nieujemne zużycie paliwa. Rok i przebieg nie mają dodatkowej walidacji. Przy remisie wybierany jest pierwszy pojazd.

Autor: Dawid Sobota.
