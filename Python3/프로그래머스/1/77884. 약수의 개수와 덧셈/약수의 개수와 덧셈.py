def solution(left, right):
    total = 0
    for x in range(left, right + 1):
        root = int (x ** 0.5)
        if root * root == x :
            total -= x
        else:
            total += x
        
    return total