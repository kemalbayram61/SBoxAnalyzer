# use the method proposed by C.Adams and S.Tavares to   
# check whether fi^fj satisfy SAC to satisfy the BIC
from __future__ import division
import numpy as np
import math
m = 8
n = 8
c = []
s=[213,149,87,93,179,170,19,158,76,40,67,12,254,220,55,44,
28,227,100,196,128,131,183,48,143,80,164,5,10,32,162,248,
186,250,4,249,99,127,23,188,163,6,147,240,11,195,226,102,
201,243,116,217,218,187,60,133,34,101,210,132,219,148,232,82,
174,242,81,129,72,33,184,175,115,193,130,24,192,185,239,45,
108,7,118,206,90,84,211,13,109,8,91,233,197,155,251,85,
119,46,134,235,202,140,73,25,176,156,37,212,36,252,203,14,
165,61,15,63,62,64,16,167,166,74,177,26,228,52,141,38,
65,168,17,53,238,57,56,172,21,69,198,234,68,229,171,42,
20,51,58,204,207,199,181,41,78,139,30,180,215,29,77,144,
111,70,208,173,255,230,145,22,157,253,92,160,159,86,246,2,
245,1,54,216,66,110,169,189,97,224,18,178,124,47,96,39,
75,114,125,43,236,106,88,27,231,214,112,71,137,190,126,49,
153,103,142,113,94,122,223,152,221,135,121,150,237,104,182,191,
222,151,241,105,136,154,138,120,79,0,244,209,123,95,117,83,
98,35,194,89,50,107,225,3,31,247,146,200,161,59,205,9]
y = np.zeros((n,m), dtype=int)
z = np.zeros((n,m))
for i in range(m):
    c.append(2**i)

# calculate the dependence matrix of fi^fj 
for x in range(2**m):
    for k in range(m):
        for j in range(m):
            for i in range(n):
                y[i][j] = y[i][j]+(((s[x]>>i)&1)^((s[x]>>j)&1))^(((s[x^c[k]]>>i)&1)^((s[x^c[k]]>>j)&1))

sumsac = 0
# calculate every element in the dependence matrix of fi^fj 
for j in range(m):
    for i in range(n):
        z[i][j] = round(y[i][j]/(2**m*m),4)
        sumsac = sumsac + z[i][j]

avesumsac = round(sumsac/56,4)

# print the dependence matrix and the average value of the elements
print z
print avesumsac


