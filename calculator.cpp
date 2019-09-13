#include <math.h> // for the pow function
#include <iostream> // for the outputting of the final value
#include <string> // for converting the final value to a string to output

float pi_calc(int digits){
    float m1 = 1; // mass of block on left (smaller)
    float m2 = std::pow(100,(digits-1)); // mass of block which hits smaller block mass

    float u1 = 0; // initial velocity of block on left
    float u2 =-1; // initial velocity of block on right (moving to the left)
    float v1 = 0;
    float v2 = 0;
	
	float a1 = ((m1-m2)/sm);
	float a2 = ((2*m2)/sm);
	float b1 = ((2*m1)/sm);
	float b2 = ((m2-m1)/sm);
	
    int piCalculated = 0; // counts each collision
    float sm = (m1+m2);
    bool run = true;

    while(run){
        piCalculated=piCalculated+1;
        if (u1<u2 and u1 < 0){ //If the magnitude of u1 is smaller than u2 and it is negative (so going to the right) then it hits the wall
            u1 = u1*-1;
        }
        else{ // otherwise, it changes momentum
            v1 = a1*u1 + a2*u2;
            v2 = b1*u1 + b2*u2;
            u1=v1;
            u2=v2;

        }
        if(u1<u2 and u1>0){ // if velocity of u2 is greater (and positive), means it won't collide with u1 again so calculation should stop
            run = false;
        }
    }
    return piCalculated/pow(10,digits-1);
}

int main(){
 std::cout << std::to_string(pi_calc(6));
 return(0);
}
