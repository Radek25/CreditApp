
# Projekt zaliczeniowy C#
Projekt zaliczeniowy - aplikacja do zarządzania pożyczkami

## Technologie
- C#
## Opis aplikacji
Aplikacja powstała w celu kontrolowania dłużników. Z racji iż ostatnimi czasy często pożyczam znajomym pieniądze wykonałem aplikację, która pozwoli mi zapisywać zadłużone wobec mnie osoby i kontrolować pożyczone sumy.
Program składa się z przejrzystego interface'u, który umożliwia dodanie  dłużnika oraz szczegółów jego długu (kwoty zadłużenia, procentu na jaki zostanie udzielona pożyczka oraz daty udzielenia pożyczki wpisywanej automatycznie po pobraniu jej z systemu). Możemy także modyfikować dłużników, a także ich usuwać. 
Kolejnymi opcjami są możliwości wyświetlenia wszystkich dłużników wraz z kwotą pożyczonych pieniędzy, kwotą pożyczonych pieniędzy i dodanym do tej kwoty procentem na jaki pożyczyłem pieniądze, a także daty pożyczki.
Ostatnia opcja z menu to wyjście z aplikacji.
## Wykonanie
Aplikacja została wykonana z użyciem języka C# w oparciu o programowanie obiektowe. Część interface'u oddzielona jest od częsci logiki. W osobnej klasie znajduje się też enum wraz z funkcjami sumującymi kwoty pożyczek (z oraz bez procentu). Dodatkowo dla switch została utworzona dodatkowa klasa aby zapewnić jak największą obiektowość programu.
