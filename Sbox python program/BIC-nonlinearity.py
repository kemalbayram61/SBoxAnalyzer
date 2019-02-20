# use the method proposed by C.Adams and S.Tavares to   
# check whether fi^fj is nonlinear to satisfy the BIC
import numpy as np
m = 8
n = 8
s = [213,149,87,93,179,170,19,158,76,40,67,12,254,220,55,44,
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
# define the dot product of x and w in Walsh spectrum 
def dianji(x,y):
    r = []
    t = []
    z = 0
    for i in range(m):
        r.append((x>>i)&1)
    for i in range(m):
        t.append((y>>i)&1)
    for i in range(m):
        z = z^(r[i]*t[i])
    return z


# calculate Walsh spectrum with the equation
for j in range(n):
    sf = np.zeros((n,2**m), dtype=int)
    maxsf = np.zeros((n,), dtype=int)
    nf = np.zeros((n,), dtype=int)
    for i in range(n):
        for w in range(2**m):
            for x in range(2**m):
                sf[i][w] = sf[i][w] + (-1)**(((s[x]>>i)&1)^((s[x]>>j)&1)^(dianji(x,w)))

    # calculate the nonlinearity Nf described with the Walsh spectrum
    for i in range(n):
        for w in range(2**m):
            if maxsf[i]<abs(sf[i][w]):
                maxsf[i] = abs(sf[i][w])
    for i in range(n):
        nf[i] = (2**(m-1))*(1-(2**(-m))*(maxsf[i]))
    print nf
    # print the nonlinearity of the Boolean functions of fi^fj
