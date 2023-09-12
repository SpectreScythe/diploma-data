#include<stdio.h>
void sum_of_odd_till_20(){
    int sum=0;
    printf("--->Program for sum of all odd numbers till 20...");
    for(int i=1;i<20;i+=2){
        sum=sum+i;
    }
    printf(" Sum of all odd till 2- is : %d", sum);
}
int main(){
    sum_of_odd_till_20();
    return 0;
}