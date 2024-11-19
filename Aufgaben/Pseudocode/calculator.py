a = int(input('number a: '))
b = int(input('number b: '))
operator = input('operator: ')

match operator:
    case '+':
        print("a + b = ", a+b)
    case '-':
        print("a - b = ", a-b)
    case '*':
        print("a * b = ", a*b)
    case '/':
        print("a / b = ", a/b)
    case '^':
        print("a ^ b = ", a**b)