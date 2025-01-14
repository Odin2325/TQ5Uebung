**SQLite und Windows Forms Aufgabenstellung: Bank Programm**

### Aufgaben Ziel
Wir erstellen ein Bank Program der SQLite und Windows Forms verwendet. Wir üben hiermit Windows Forms, Datenbank-Interaktionen, Benutzerauthentifizierung und benutzerfreundliche Interfaces.

---

### **1. Programmier Umgebung vorbereiten**

**Ziel**: Wir erstellen ein Windows Forms Projekt und bereiten SQLite auf Datenbank-Interaktionen vor.

**Schritte**:
1. Installiere das SQLite NuGet Package: `System.Data.SQLite`.
2. Erstelle eine Hilfsklasse die unsere SQLite Verbindung verwaltet.

---

### **2. Datenbank Schema entwickeln**

![alt text](https://github.com/Odin2325/TQ5Uebung/blob/main/BankProjekt/BankDBSchema.png?raw=true)

**Ziel**: Definiere Tabellen die unsere Informationen speichern soll. **Achte auf die Foreign Keys.**

**Schritte**:
1. Erstelle eine neue Datenbank (`Bank.db`).
2. Erstelle die Tabellen wie in das BankDBSchema definiert.
3. Befülle die Tabellen mit daten:

**Person**: Erstelle 15 weitere Beispieleingaben.

```SQLite
INSERT INTO Person (PersonID, LastName, FirstName, DateOfBirth, Email, PhoneNumber, Address, TaxIdentifier) VALUES
(1, 'Smith', 'John', '1985-06-15', 'john.smith@example.com', '1234567890', '123 Elm St', 'TAX1234567'),
(2, 'Doe', 'Jane', '1990-09-23', 'jane.doe@example.com', '0987654321', '456 Oak St', 'TAX7654321'),
(3, 'Brown', 'Charlie', '1982-11-04', 'charlie.brown@example.com', '1122334455', '789 Maple St', 'TAX1122334'),
```

**Customer**: Erstelle 20 weitere Beispieleingaben.

```SQLite
INSERT INTO Customer (CustomerID, PersonID, CustomerType) VALUES
(1, 1, 'Individual'),
(2, 2, 'Corporate'),
(3, 3, 'Individual'),
```

**Employee**: Erstelle 5 weitere Beispieleingaben.

```SQLite
INSERT INTO Employee (EmployeeID, PersonID, Position) VALUES
(1, 4, 'Manager'),
(2, 5, 'Teller'),
(3, 6, 'Clerk'),
```

**Branch**

```SQLite
INSERT INTO Branch (BranchID, BranchName, BranchCode, Address, PhoneNumber) VALUES
(1, 'Main Branch', 'BR001', '100 Central Ave', '5551112222'),
(2, 'West Branch', 'BR002', '200 West St', '5553334444'),
(3, 'East Branch', 'BR003', '300 East Blvd', '5555556666'),
```

**Account**: Erstelle 30 weitere Beispieleingaben.

```SQLite
INSERT INTO Account (AccountID, CustomerID, AccountNumber, AccountType, CurrentBalance, DateOpened, DateClosed, AccountStatus, AccountPin) VALUES
(1, 1, 'AC001', 'Savings', 1500.50, '2020-01-15', NULL, 'Active', 1234),
(2, 2, 'AC002', 'Checking', 12000.00, '2019-03-10', NULL, 'Active', 4321),
(3, 3, 'AC003', 'Savings', 800.75, '2021-05-20', NULL, 'Active', 9424),
```

**Transaction**: Erstelle 30 weitere Beispieleingaben.

```SQLite
INSERT INTO Transaction (TransactionID, AccountID, TransactionType, Amount, TransactionDate, CurrentBankAmount) VALUES
(1, 1, 'Deposit', 500.00, '2022-01-10', 1430.00),
(2, 1, 'Withdrawal', 100.00, '2022-02-15', 54083.00),
(3, 2, 'Deposit', 2000.00, '2022-03-05', 21053.00),
```

**Loan**: Erstelle 10 weitere Beispieleingaben.

```SQLite
INSERT INTO Loan (LoanID, CustomerID, LoanType, LoanAmount, InterestRate, Term, StartDate, EndDate, LoanStatus) VALUES
(1, 1, 'Home', 250000.00, 3.5, 30, '2018-06-01', '2048-06-01', 'Active'),
(2, 2, 'Auto', 30000.00, 4.0, 5, '2020-09-15', '2025-09-15', 'Active'),
(3, 3, 'Personal', 10000.00, 5.0, 3, '2021-01-10', '2024-01-10', 'Active'),
```

**LoanPayment**: Erstelle 12 weitere Beispieleingaben.

```SQLite
INSERT INTO LoanPayment (LoanPaymentID, LoanID, ScheduledPaymentDate, PaymentAmount, PrincipalAmount, InterestAmount, PaidAmount, PaidDate) VALUES
(1, 1, '2022-01-01', 1200.00, 1000.00, 200.00, 1200.00, '2022-01-01'),
(2, 1, '2022-02-01', 1200.00, 1000.00, 200.00, 1200.00, '2022-02-01'),
(3, 2, '2022-03-15', 650.00, 600.00, 50.00, 650.00, '2022-03-15'),
```

---

### **Entitäten Erklärungen**:

**Filiale (Branch)**

1. Diese Entität speichert grundlegende Informationen über die verschiedenen Filialen oder Büros der Bank. Sie enthält folgende Attribute:
   1. `BranchID`: Eine eindeutige Identifikationsnummer und der surrogate Primary Key der Tabelle. INTEGER
   2. `BranchName`: Der kommerzielle Name der Filiale oder des Büros und ein zusätzlicher Identifikator. (Es darf keine zwei Filialen mit demselben Namen geben.) VARCHAR(100) Datentyp.
   3. `BranchCode`: Ein interner Code, der verwendet wird, um die Filiale in Kontonummern zu identifizieren. Dies ist ebenfalls ein zusätzlicher Identifikator, da es keine zwei Filialen mit demselben Code geben darf. VARCHAR(10) Datentyp.
   4. `Address`: Die physische Adresse dieser Filiale. Wie bei der Person-Entität normalisieren wir diese Informationen der Einfachheit halber nicht. VARCHAR(100) Datentyp.
   5. `PhoneNumber`: Die Telefonnummer der Filiale. VARCHAR(20) Datentyp.

**Mitarbeiter (Employee)**

1. Diese Entität speichert Informationen über Personen, die auch Bankangestellte sind. Zusätzlich zu allen Attributen der Entität Person besitzen sie folgende zusätzliche Attribute:
   1. `EmployeeID`: Eine eindeutige ID-Nummer und der surrogate Primary Key der Tabelle. INTEGER
   2. `Position`: Beschreibt die Position des Mitarbeiters. VARCHAR(20) Datentyp.
    

**Kunde (Customer)**

1. Diese Entität speichert Informationen über Personen, die auch Bankkunden sind. Zusätzlich zu allen Attributen der Entität Person besitzen sie folgende zusätzliche Attribute:
   1. `CustomerID`: Eine eindeutige Identifikationsnummer und der surrogate Primary Key der Tabelle. INTEGER
   2. `CustomerType`: Kategorisiert den Kunden basierend auf den Bankrichtlinien (z. B. regulär, Premium usw.). VARCHAR(20) Datentyp.


**Konto (Account)**

1. Diese Entität speichert Informationen über die verschiedenen Konten, die jeder Kunde oder jede Kundengruppe bei der Bank haben kann. Sie enthält folgende Attribute:
   1. `AccountID`: Der surrogate Primary Key der Tabelle. INTEGER
   2. `AccountType`: Definiert den Kontotyp (z. B. Sparkonto, Girokonto, Kreditkonto usw.) und dient als Teil des eindeutigen Identifikators der Entität. VARCHAR(20) Datentyp.
   3. `AccountNumber`: Zusammen mit dem AccountType identifiziert dies das Konto eindeutig in der Bank. Es enthält üblicherweise den Filialcode. VARCHAR(20) Datentyp.
   4. `CurrentBalance`: Der aktuelle verfügbare Kontostand. DECIMAL(10, 2) Datentyp.
   5. `DateOpened`: Datum, an dem das Konto eröffnet wurde. DATE
   6. `DateClosed`: Datum, an dem das Konto geschlossen wurde. DATE Datentyp und nicht obligatorisch.
   7. `AccountStatus`: Definiert, ob das Konto aktiv, gesperrt, geschlossen usw. ist. VARCHAR(20) Datentyp.

**Kreditrückzahlung (Loan)**

1. Kredite haben in der Regel eine geplante Anzahl von Zahlungen, die sowohl den Kapitalbetrag als auch die Zinsen umfassen. Die Entität "Kreditrückzahlung" in unserem Modell stellt diese geplanten Zahlungen dar. Sie hat die folgenden Attribute:
   1. `LoanPaymentID`: Der surrogate Primärschlüssel der Tabelle. INTEGER
   2. `ScheduledPaymentDate`: Das vorab festgelegte Datum jeder Zahlung. DATE
   3. `PaymentAmount`: Der erwartete Gesamtbetrag, der am geplanten Datum zu zahlen ist. Datentyp DECIMAL(10, 2).
   4. `PrincipalAmount`: Der erwartete Kapitalbetrag, der am geplanten Datum zu zahlen ist. Datentyp DECIMAL(10, 2).
   5. `InterestAmount`: Der erwartete Zinsbetrag, der am geplanten Datum zu zahlen ist. Datentyp DECIMAL(10, 2).
   6. `PaidAmount`: Der tatsächlich gezahlte Betrag. Datentyp DECIMAL(10, 2).
   7. `PaidDate`: Das tatsächliche Datum, an dem die Zahlung abgeschlossen wurde. Datentyp DATE und nicht obligatorisch.

**Transaktion**

1. Jede durchgeführte Operation in einer Bank wird in der Regel durch eine Transaktion (z. B. Einzahlung, Abhebung) oder mehrere Transaktionen (z. B. Kontotransfers) dargestellt. Die Entität "Transaktion" in unserem Modell wird diese Operationen verwalten. Sie hat die folgenden Attribute:
   1. `TransactionID`: Der surrogate Primärschlüssel der Tabelle. INTEGER
   2. `TransactionType`: Definiert den Typ der durchgeführten Transaktion (z. B. Einzahlung, Abhebung, Überweisung). Datentyp VARCHAR(20).
   3. `Amount`: Der Betrag, der an der Operation beteiligt ist. Datentyp DECIMAL(10, 2).
   4. `TransactionDate`: Das Datum und die Uhrzeit, zu der die Transaktion durchgeführt wurde. Datentyp DATETIME.
   5. `CurrentBankAmount`: Das Aktueller Kontostand nachdem eine Transaktion durchgeführt worden ist.

---

### **3. UML Diagramme erstellen**

1. Klassendiagramm erstellen für unser System.
2. Aktivitätsdiagramm für einen Kunden, der eine Geldüberweisung ausführen möchte.

---

### **4. Klassen erstellen**

**Ziel**: Erstellt eine Klasse die jede Tabelle repräsentieren soll. Dies ist in der Programmierung ein DAL. Ein Data Access Layer (DAL) ist eine Schicht in der Softwarearchitektur, die den Zugriff auf Daten in einer Datenbank oder einem anderen Speichersystem vereinfacht. Er ermöglicht es der Anwendung, Daten zu speichern und abzurufen, ohne sich um die spezifischen Details der Datenbank kümmern zu müssen.

---

### **5. Login Feature erstellen**

**Ziel**: Erlaube es Benutzer mit ihren `AccountID` und `AccountPin` sich selbst einzuloggen.

**Steps**:
1. Erstelle einen Windows Forms Login Form.
2. Der Benutzer soll aufgefordert werden seinen `AccountID` und `AccountPin` zu verwenden um sich einzuloggen.
3. Validiere die Eingaben mit unserer Datenbank.
4. Wir unterscheiden zwischen die Kunden `Corporate` und `Individual`. Einige eigenschaften sind gemeinsam und einige gehören nur zu einem bestimmten `AccountType` (Hinweis abstrakt und virtuell).

---

**Gemeinsame Eigenschaften**

Login Form:

    Benutzername und Passwort Eingabefelder.
    Dropdown, um den Accounttyp auszuwählen: "Individual" oder "Corporate".
    Login Status speichern (e.g., checkbox für "Remember Me").

Konto Details sehen:

    Aktueller Kontostand
    Konto Status (active, inactive, closed).
    Neue Kontohistorie (Filter bspw. letzte 2 Wochen).

Konto Sicherheit:

    Wenn ein Konto mehr als 40% seines Aktuellen Kontostands auszahlen möchte, dann soll eine überprüfung stattfinden, wo die person seinen TaxIdentifier eingeben muss um fortzufahren.
    Dieser Maximum soll für Corporationen auf 20% runtergestellt werden.
        Bspw: Ein Kunde hat 1000 Euro und will 600 auszahlen. Dies soll nicht möglich sein.
        Eine Corporation hat 1000 Euro und will 600 auszahlen. Dies soll nicht möglich sein.
        Ein Kunde hat 1000 Euro und will 350 auszahlen. Dies soll möglich sein.
        Eine Corporation hat 1000 Euro und will 350 auszahlen. Dies soll nicht möglich sein.
        Ein Kunde hat 1000 Euro und will 150 auszahlen. Dies soll möglich sein.
        Eine Corporation hat 1000 Euro und will 150 auszahlen. Dies soll möglich sein.

    Wenn ein Pin mehr als 3 mal falsch eingegeben wird, dann soll das Konto gesperrt werden.

    Gerne weitere Sicherheitsfunktionen hinzufügen.

Transaktion durchführen:

    Erlaube einem Benutzer Geld einzuzahlen, Geld auszuzahlen und auch Kontoüberweisungen auszuführen.

Passwort ändern:

    Erlaube dem Benutzer das Passwort zu ändern.

Logoutknopf:

    Einfache Lösung um sich auszuloggen.

---

**Individual**

Verwaltung persönlicher Informationen:

    Persönliche Daten anzeigen und aktualisieren (z. B. Adresse, Telefonnummer).
    Identifikationsdokumente hochladen/überprüfen.

Bankgeschäfte:

    Geld einzahlen (simulierte Aktion oder Platzhalter für echte Bank-API).
    Geld abheben (simulierte Abbuchung).
    Geld auf andere Konten überweisen (Empfängerkontonummer und Betrag eingeben).

Kreditverwaltung:

    Kredite beantragen (z. B. Formular mit Kreditbetrag, Verwendungszweck und Laufzeit ausfüllen).
    Aktive Kredite und Zahlungstermine anzeigen.
    Kreditrückzahlungen vornehmen.

    Kreditelogik implementieren: Wer darf Geld ausleihen? Bspw: Kunde darf nur Kredite bekommen oder Geld von der Bank ausleihen, wenn kein Loan momentan aktiv ist und der aktuelle Kontostand nie auf 0 war.

Budgetierungstools:

    Budgets für monatlichen Ausgaben hinzufügen und verfolgen.
    Sparziele anzeigen.

Transaktionshistorie anzeigen:

    Detaillierte Historie mit Filteroptionen (Datum, Transaktionstyp, Betrag).

---

**Corporate**

Mitarbeiterverwaltung:

    Mitarbeiterkonten hinzufügen, entfernen oder aktualisieren, die mit dem Unternehmen verknüpft sind.
    Rollen an Mitarbeiter zuweisen (z. B. Manager, Buchhalter). D.h. Die sollten den gleichen Kundennummer haben.
    Möglicherweise müssen wir eine neue Spalte zu eine Tabelle hinzufügen.

Massentransaktionen:

    Massenüberweisungen an mehrere Empfänger durchführen.

Finanzberichterstattung:

    Detaillierte Berichte über Kontobewegungen erstellen (z. B. Einnahmen, Ausgaben).
    Berichte als PDF oder Excel exportieren.

Kreditverwaltung für geschäftliche Zwecke:

    Geschäftskredite mit unterschiedlichen Konditionen beantragen. Bspw: Nicht notwendig, dass der Konto nie auf 0 gegangen ist.
    Darf auch Geld ausleiehen, wenn schon Geld ausgeliehen worden ist.
    Aktive Kredite und Zahlungstermine verwalten.

---

### **6. Menu Form**

**Ziel**: Nach Login, Menu mit allen möglichen Operationen anzeigen.

**Schritte**:
1. Erstelle ein neues `MenuForm`.
2. Füge Knöpfe hinzu wie bspw: Kontodetails, viewing transaction history, deposits, and withdrawals.
3. Auch mehrere Forms verknüpfen, die geöffnet werden wenn eine Option ausgewählt worden ist.
   1. Bspw: Auf Kontodetails drücken und dann wird ein weiterer Form geöffnet mit den Kontodetails. Der alte Form wird geschlossen.
   2. Danach wenn wir Kontodetails schliessen, kommen wir wieder auf unsem originalen Menu mit allen Optionen.

---

### **7. Error Handling und Validierung Erstellen**

**Ziel**: Sicherstellen, dass der Programm nie abstürzt, sondern Fehler werden auf ein Fenster angezeigt und wir können dannach weiterarbeiten.

**Code Beispiel**:
```csharp
try
{
    // Fehlerhaftes Code ausführen
}
catch (Exception ex)
{
    // Fehlermeldung in Dialogfenster beispielsweise ausgeben.
}
```

### **8. Log Datei für uns als Programmierer erstellen**

**Ziel**: Wir möchten eine Log Datei erstellen wo wir Daten abspeichern wenn ein Fehler auftretet. Wir sollten dann dadrauf zugreifen können, aber der Kunde soll es nie sehen.

1. Wir erstellen bspw eine txt-Datei.
2. Wenn ein Fehler auftritt, dann soll zu diese Log Datei alle Informationen geschrieben werden. Bspw: Aktuelle Form, Knopf, den Fehler verursacht hat, wieso ein Fehler aufgetreten ist, Fehler Art und Uhrzeit.
3. Diese Informationen sollten in eine sinnvolle formatierung gespeichert werden.

---

### **9. Dokumentation erstellen**

**Ziel**: Mit docfx eine Datei erstellen, die all unseren Projektinformationen enthält. Alles soll mit XML-Kommentare dokumentiert sein.

---

### **10. App veröffentlichen**

---

# Fertig!