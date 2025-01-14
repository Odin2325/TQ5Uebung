**SQLite und Windows Forms Aufgabenstellung: Bank Programm**

### Aufgaben Ziel
Wir erstellen einen Bank Program der SQLite und Windows Forms verwendet. Wir Üben hiermit Windows Forms, datenbank interaktionen, benutzer Authentifizierung und benutzer freundliche Interfaces.

---

### **1. Programmier Umgebung vorbereiten**

**Ziel**: Wir erstellen einen Windows Forms Projekt und bereiten SQLite vor für datenbank interaktionen.

**Schritte**:
1. Installiere das SQLite NuGet package: `System.Data.SQLite`.
2. Erstellt eine Hilfsklasse die unsere SQLite verbindung Verwaltet.

---

### **2. Datenbank Schema entwickeln**



**Ziel**: Definiere tabellen die unsere informationen speichern soll.

**Schritte**:
1. Erstelle eine neue Datenbank (`Bank.db`).
2. Erstelle die Folgenden 
3. Add a `BankPIN` column to the `Accounts` table.


---

### **3. Create Login Feature**

**Objective**: Allow users to log in using their `AccountID` and `BankPIN`.

**Steps**:
1. Create a login form in Windows Forms.
2. Add a `TextBox` for `AccountID` input and a password field for `BankPIN` input.
3. Validate the login credentials against the database.

**Methoden Signatur Beispiel**:
```csharp
private void btnLogin_Click(object sender, EventArgs e)
{
    // Validate user login
}
```

```csharp
public static bool ValidateLogin(int accountId, string bankPIN)
{
    // Check credentials in the database
}
```

---

### **4. Menu Form**

**Objective**: After login, display a menu with all possible operations.

**Steps**:
1. Create a new `MenuForm`.
2. Add buttons for operations like viewing account details, viewing transaction history, deposits, and withdrawals.

**Methoden Signatur Beispiel**:
```csharp
public partial class MenuForm : Form
{
    public MenuForm(int accountId)
    {
        // Initialize form with accountId
    }

    private void btnViewAccountDetails_Click(object sender, EventArgs e)
    {
        // Display account details
    }

    private void btnViewTransactions_Click(object sender, EventArgs e)
    {
        // Display transaction history
    }
}
```

---

### **5. Design the User Interface**

**Objective**: Create the UI for basic banking operations.

**Steps**:
1. Use Visual Studio’s Designer to add controls like `DataGridView`, `TextBox`, and `Button`.
2. Connect the controls to code-behind logic.

**Code Snippet**:
```csharp
private void btnLoadCustomers_Click(object sender, EventArgs e)
{
    // Load customer data into DataGridView
}
```

---

### **6. Create the Data Access Layer (DAL)**

**Objective**: Implement classes to interact with the SQLite database.

**Methoden Signatur Beispiel**:
```csharp
public static List<Customer> GetAllCustomers()
{
    // Retrieve all customers from the database
}
```

```csharp
public class Customer
{
    // Define Customer properties: CustomerId, Name, Email
}
```

---

### **7. Implement Business Logic**

**Objective**: Introduce a business logic layer to handle banking operations like transactions.

**Methoden Signatur Beispiel**:
```csharp
public static void PerformTransaction(Account account, double amount, string type)
{
    // Perform deposit or withdrawal
}
```

---

### **8. Add Error Handling and Validation**

**Objective**: Ensure the program handles common errors gracefully.

**Code Snippet**:
```csharp
try
{
    // Handle transaction errors
}
catch (Exception ex)
{
    // Display error message
}
```

