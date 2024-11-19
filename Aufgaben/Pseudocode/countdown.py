import time

countdown = int(input("countdown from: "))

for i in range(countdown, 0, -1):
    print(i)
    time.sleep(1)

print(0)