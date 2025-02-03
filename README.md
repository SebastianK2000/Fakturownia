# Invoice System

A desktop application written in C# based on the MVVM design pattern.

# View

<details>


### Invoice list view 

![image](https://github.com/user-attachments/assets/8eabe84d-7b25-4a5e-8ddc-21d66b4242b8)

### Add Invoice

![image](https://github.com/user-attachments/assets/4ed4afb9-9873-4e84-8355-8097b575db83)

### Generate Raports 

![image](https://github.com/user-attachments/assets/a020e37e-0881-4e60-a596-ada9280388ec)

### Other View

![image](https://github.com/user-attachments/assets/a3bfd090-cc58-48a1-8c06-c2027e0642fe)

![image](https://github.com/user-attachments/assets/002a9046-167d-47a8-88c3-08dfefa8bec9)

![image](https://github.com/user-attachments/assets/fcc06b88-0e32-41fb-8523-7fc93a87054c)


</details>


# Installation

To run the project locally we need 
- Visual Studio https://visualstudio.microsoft.com/pl/vs/community/
- Extensions for Visual Studio such as SQL Server Data Tools, Classic Application Programming for .NET platform
- Microsoft SQL Server - https://www.microsoft.com/pl-pl/sql-server/sql-server-downloads

When we have installed all the necessary things we move to the next step. To begin with, we need to import the invoice.bak file into our SQL Server Managment Studio 20 to create the database needed for the project.

Then we copy the project from my Github. 

 Copy the address:

   https://github.com/SebastianK2000/Fakturownia

   type in terminal:

   ```
   git clone https://github.com/SebastianK2000/Fakturownia.git
   ```

![image](https://github.com/user-attachments/assets/baf9f988-6959-4f5c-ada2-eb3f9f9fa76a)

# Description 

Invoice is a Desktop application written in C# language using Entity Framework, XAML and MS SQL. The application has such functionalities as: 
- Adding new customers / contractors.
- Entering company data into the system.
- Creating invoices for service / goods which we can also add to the stystem.
- Management from admin level (currently available only profile from admin level).
- Generating sales, VAT and new user reports.
- CRUD type operation on almost every table.
- Modal windows.
- Comboboxes.
- Business logics.
- Extensive views.
- Sorting and filtering.
- Validation of fields in forms.


# Technologies

- C#
- Entity Framework
- LINQ
- XAML
- MS SQL
- GIT

# Code Example

```
        private void ShowView<T>() where T : WorkspaceViewModel, new() // Element show 
        {
            T workspace = this.Workspaces.OfType<T>().FirstOrDefault();

            if (workspace == null)
            {
                workspace = new T();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
```



<hr>



# PL


# Fakturownia

Desktopowa aplikacja napisana w C# oparta na wzorcu projektowym MVVM.

# Instalacja

Aby uruchomić projekt lokalnie potrzebujemy 
- Visual Studio https://visualstudio.microsoft.com/pl/vs/community/
- Rozszerzenia do Visual Studio takie jak: SQL Server Data Tools, Programowanie aplikacji klasycznych dla platformy .NET
- Microsoft SQL Server - https://www.microsoft.com/pl-pl/sql-server/sql-server-downloads

Kiedy mamy zainstalowane wszystkie potrzebne rzezczy przechodzimy do następnego kroku. Na poczętek musimy importować plik fakturownia.bak do naszego SQL Server Managment Studio 20 aby utworzyć bazę danych potrzebną do projektu.

Następnie kopiujemy projekt z mojego Githuba. 

   Copy the address:

   https://github.com/SebastianK2000/Fakturownia

   type in terminal:

   ```
   git clone https://github.com/SebastianK2000/Fakturownia.git
   ```
   #### Right click on the folder and select “Open in Visual Studio”. 

   #### We choose the solution: app.xaml

# Project structure

   #### Prawym przyciskiem na myszy naciskamy na folder i wybieramy opcję "Otwórz w Visual Studio". 

   #### Wybieramy solucję: App.xaml

# Struktura projektu

![image](https://github.com/user-attachments/assets/baf9f988-6959-4f5c-ada2-eb3f9f9fa76a)


# Opis 

Fakturownia jest Desktopową aplikacją napisaną w języku C# z użyciem Entity Framework, XAML oraz MS SQL. Aplikacja posiada takie funkcjonalności jak: 
- Dodawanie nowych klientów / kontrahentów.
- Wprowadzanie danych firmy do systemu.
- Tworzenie faktur za usługę / towar który również możemy dodać do stystemu.
- Zarządzanie z poziomu admina (aktualnie dostępny wyłącznie profil z poziomu admina).
- Generowanie raportów sprzedaży, VAT oraz nowych urzytkowników.
- Operację typu CRUD na prawie każdej tabeli.
- Okna modalne.
- Comboboxy.
- Logiki Biznesowe.
- Rozbudowane widoki.
- Sortowanie oraz filtrowanie.
- Walidacja pól w formularzach.


# Technologie

- C#
- Entity Framework
- LINQ
- XAML
- MS SQL
- GIT

# Code Example

```
        private void ShowView<T>() where T : WorkspaceViewModel, new() // Element show 
        {
            T workspace = this.Workspaces.OfType<T>().FirstOrDefault();

            if (workspace == null)
            {
                workspace = new T();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }

        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
```
