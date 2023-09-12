#include<stdio.h>
void exam(){
    int a[5],sum=0;
    int *ptr;
    ptr=&a[1];
    for(int i=1;i<=5;i++){
        printf(" Enter A[5] of %d : ",i);
        scanf(" %d",&a[i]);
    }
    for(int i=1;i<=5;i++){
        sum=sum+(*ptr);
        ptr=ptr+1;
    }
    printf(" Sum = %d",sum);
}
int main(){
    exam();
    return 0;
}