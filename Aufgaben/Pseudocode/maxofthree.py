def findLargest(list):
    largest = list[0]
    for number in list:
        if number > largest:
            largest = number
    return largest
list = str.split(input('ints separated with comma: '), ',')
print(findLargest(list))