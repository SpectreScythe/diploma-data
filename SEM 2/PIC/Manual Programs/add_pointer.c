#include<stdio.h>
void swap_pointer(int *a,int*b){
    int temp;
    temp=*a;
    *a=*b;
    *b=temp;
}
int main(){
    int x,y;
    int sum;
    printf(" Enter value for X and Y:");
    scanf("%d%d",&x,&y);
    swap_pointer(&x,&y);
    printf(" x=%d,y=%d",x,y);
    sum=x+y;
    printf(" Sum = %d",sum);
    return 0;
}