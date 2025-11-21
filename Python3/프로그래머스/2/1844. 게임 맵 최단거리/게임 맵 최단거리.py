import sys
from collections import deque

def solution(maps):
    n = len(maps)
    m = len(maps[0])
    
    dist = [[-1] * m for _ in range(n)]
    
    dx = [-1 , 1 , 0 , 0]
    dy = [0 , 0 , -1 , 1]
    
    q = deque()
    
    if maps[0][0] == 0:
        return -1
    
    dist [0][0] = 1
    q.append((0 , 0))
    
    while q:
        x, y = q.popleft()
        
        if x == n - 1 and y == m - 1:
            return dist[x][y]
        
        for dir in range(4):
            nx = x + dx[dir]
            ny = y + dy[dir]
            
            if nx < 0 or nx >= n or ny < 0 or ny >= m:
                continue
            if maps[nx][ny] == 0:
                continue
                
            if dist[nx][ny] != -1:
                continue
                
            dist[nx][ny] = dist[x][y] + 1
            q.append((nx , ny))
            
    return -1