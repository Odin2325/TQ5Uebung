limit = int(input('sum even integers from 0 to: '))

sum = 0
i = 0
while i <= limit:
    sum += i
    i += 2

print(sum)