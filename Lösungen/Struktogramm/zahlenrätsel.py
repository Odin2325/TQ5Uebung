import random

targetNumber = random.randint(1, 100)

while True:
    userNumber = int(input("Errate die Zahl. (Sie liegt zwischen 1 und 100): "))

    if userNumber == targetNumber:
        print("Herzlichen Glückwunsch! Du hast die Zahl erraten.")
        break
    else:
        if userNumber < targetNumber:
            print("Die Zahl ist zu klein. Versuch es nochmal!")
        elif userNumber > targetNumber:
            print("Die Zahl ist zu groß. Versuch es nochmal!")

print(f"Die zuvor gewählte Zahl war: {targetNumber}")