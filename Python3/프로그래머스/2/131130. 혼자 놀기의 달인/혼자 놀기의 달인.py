import sys

def solution(cards):
    n = len(cards)
    visited = [False] * n
    groups = []
    
    for i in range(n):
        if visited[i]:
            continue
        
        cnt = 0
        cur = i
        while not visited[cur]:
            visited[cur] = True
            cnt += 1
            cur = cards[cur] - 1
            
        if cnt > 0:
            groups.append(cnt)
            
    if len(groups) < 2:
        return 0
        
    groups.sort(reverse = True)
    return groups[0] * groups[1]