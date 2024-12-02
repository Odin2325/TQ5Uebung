noten = []
durchschnitt = 0

while True:  
    summe = int(input("Wieviele Noten gibt es?: "))
    if summe > 0:
        break 
    else:
        print("Die Anzahl der Noten muss größer als 0 sein. Bitte erneut eingeben.")

while len(noten) < summe:
    note = int(input("Bitte gib eine Note ein: "))
    noten.append(note)

durchschnitt = sum(noten) / len(noten)

print(f"Der Durchschnitt beträgt: {durchschnitt}")

if durchschnitt < 4.0: 
    print("Du hast bestanden!")
else: 
    print("Du bist durchgefallen!")