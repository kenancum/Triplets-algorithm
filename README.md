# Triplets algorithm
Given an array of n distinct integers, and an integer threshold, t, how many (a,b,c) index triplets exist that satisfy both of the  following conditons?

         *d[a] < d[b] < d[c]
         *d[a] + d[b] + d[c] <= t

         *Example
         *d = [1, 2, 3, 4, 5]
         *t = 8

         *The following 4 triplets satisfy the constraints:
         *(1, 2, 3)-> 1 + 2 + 3 = 6 <= 8
         *(1, 2, 4)-> 1 + 2 + 4 = 7 <= 8
         *(1, 2, 5)-> 1 + 2 + 5 = 8 <= 8
         *(1, 3, 4)-> 1 + 3 + 4 = 8 <= 8

         *output: 4
