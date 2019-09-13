def pi(digits):
    m1 = 1 # mass of block on left (smaller)
    m2 = 100**(digits-1) # mass ofblock which hits smaller block mass

    u1 = 0 # initial velocity of block on left
    u2 = -100 # initial velocity of block on right (moving to the left)
    sm = (m1+m2) # sum of the masses
    a1 = ((m1-m2)/sm)
    a2 = ((2*m2)/sm)
    b1 = ((2*m1)/sm)
    b2 = ((m2-m1)/sm)
    
    piCalculated = 0 # counts each collision
    while(True):
        piCalculated=piCalculated+1
        if (u1<u2 and u1 < 0): #If the magnitude of u1 is smaller than u2 and it is negative (so going to the right) then it hits the wall
            u1 = -u1
        else: # otherwise, it changes momentum
            
            v1 = a1*u1 + a2*u2
            v2 = b1*u1 + b2*u2
            u1=v1
            u2=v2

        if(u1<u2 and u1>0): # if velocity of u2 is greater (and positive), means it won't collide with u1 again so calculation should stop
            break
    return piCalculated/10**(digits-1)
