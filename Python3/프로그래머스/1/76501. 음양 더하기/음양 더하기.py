def solution(absolutes, signs):
    total = 0
    
    for val, sign in zip(absolutes, signs):
        if sign:
            total += val
        else:
            total -= val
            
    return total