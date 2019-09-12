def pi(digits):
    m1 = 1 # mass of block on left (smaller)
    m2 = 100**(digits-1) # mass ofblock which hits smaller block mass

    u1 = 0 # initial velocity of block on left
    u2 = -100 # initial velocity of block on right (moving to the left)

    pi = 0 # counts each collision
    while(u1<u2): # if velocity of u2 is greater, means it won't collide with u1 again so calculation should stop
        pi=pi+1
        if (pi % 2) == 0: # if even it is colliding with the wall (on left)
            u1 = -u1
        else: # if odd, colliding with other block, this changes momentums
            sm = (m1+m2)
            v1 = ((m1-m2)/sm)*u1+((2*m2)/sm)*u2
            v2 = ((m1-m2)/sm)*u2+((2*m2)/sm)*u1
            u1=v1
            u2=v2


