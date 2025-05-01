# Aplikacje Blazor w .NET 8
> Autor: Adrian Goral

## Wstęp
Celem laboratorium jest zapoznanie się z podstawami projektowania i implementacji aplikacji webowych w technologii ASP.NET Core. W ramach zajęć należy w pierwszej kolejności zapoznać się z technologią Blazor w ramach platformy ASP.NET Core, następnie stworzyć aplikację bazodanową oraz w ostatnim kroku opublikować ją w ramach chmury Azure.

## Zadania
Laboratorium składa się z trzech głównych zadań:
1. **Zadanie 1**: Użycie platformy Blazor do stworzenia aplikacji webowej.
2. **Zadanie 2**: Użycie Entity Framework Core do stworzenia aplikacji bazodanowej.
3. **Zadanie 3**: Publikacja aplikacji w chmurze Azure.

### Zadanie 1: Użycie platformy Blazor do stworzenia aplikacji webowej
Zadanie polegało na rozszerzeniu domowej aplikacji Blazor o dodatkowe funkcjonalności takie jak:
- modyfikacja istniejących komponentów,
- dodanie nowych komponentów.

### Zadanie 2: Użycie Entity Framework Core do stworzenia aplikacji bazodanowej

W ramach tego zadania należy stworzyć prostą aplikację bazodanową w technologii Blazor z wykorzystaniem Entity Framework Core. Aplikacja powinna zawierać następujące funkcjonalności:

1. **System logowania i rejestracji użytkowników**:
   - Wykorzystanie gotowego rozwiązania oferowanego przez Blazor Web App z opcją "Individual Accounts" w polu Authentication type.
   - Obsługa rejestracji użytkowników z potwierdzeniem poprzez link aktywacyjny.

2. **Możliwość wprowadzania ocen**:
   - Użytkownicy powinni mieć możliwość dodawania ocen dla filmów, gier lub książek.

3. **Autoryzacja i ograniczenie dostępu**:
   - Dostęp do części stron powinien być zablokowany dla niezalogowanych użytkowników przy użyciu atrybutu `[Authorize]`.
   - Menu nawigacyjne powinno dynamicznie ukrywać podstrony niedostępne dla niezalogowanych użytkowników (z użyciem komponentu `<AuthorizeView>` w pliku `NavMenu.razor`).

4. **Obsługa bazy danych**:
   - Tworzenie migracji i aktualizacja bazy danych z poziomu Package Manager Console.
   - Definicja i zarządzanie bazą danych zgodnie z poznanymi wcześniej metodami.

5. **Opcjonalnie**:
   - Możliwość implementacji autoryzacji z wykorzystaniem kont Google lub Microsoft.

Aplikacja powinna być zgodna z najlepszymi praktykami projektowania aplikacji Blazor i zapewniać intuicyjny interfejs użytkownika. Wdrożenie tych funkcji pozwoli na lepsze zrozumienie technologii Blazor oraz Entity Framework Core.

### Zadanie 3: Publikacja aplikacji w chmurze Azure

## Wnioski i przemyślenia

Laboratorium umożliwiło mi poznanie nowej technologii, jaką jest Blazor oraz zapoznanie się z Azure. Wykonałem wszystkie zadania, które były wymagane w ramach laboratorium, wraz z publikacją aplikacji w chmurze Azure. Udało mi się również zrealizować dodatkowe zadania, takie jak dodanie autoryzacji z wykorzystaniem kont Google czy obsługa dodawania zdjęć. Niestety, pomimo wykonania wszystkich zadań, nie polubiłem tej technologii. Sam Blazor jak i Azure są w mojej opinii nieintuicyjne, skomplikowane i nieprzyjemne w użyciu. 