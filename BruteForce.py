import itertools

# Zielpasswort, das gefunden werden soll
target_password = "abc"
# Zeichensatz, den wir verwenden
charset = "abcdefghijklmnopqrstuvwxyz"
# Maximale Länge der Kombinationen
max_length = 3

def brute_force():
    # Schleife durch alle möglichen Längen bis max_length
    for length in range(1, max_length + 1):
        # Erzeuge alle Kombinationen der aktuellen Länge
        for attempt in itertools.product(charset, repeat=length):
            # Erstelle den Versuch als String
            attempt_str = ''.join(attempt)
            print(f"Trying: {attempt_str}")  # Debug-Ausgabe
            
            # Überprüfe, ob der aktuelle Versuch das Passwort ist
            if attempt_str == target_password:
                print(f"Password found: {attempt_str}")
                return  # Beende die Funktion, sobald das Passwort gefunden ist

    print("Password not found within max length.")

# Startet den Brute-Force-Versuch
brute_force()
