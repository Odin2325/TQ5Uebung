def findLargest(list):
    largest = list[0]
    for number in list:
        if number > largest:
            largest = number
    return largest
list = [5,3,8,2]

n = 4
for i in range(1,n+1):
    print(' '*(n-i) + '* '*i)