#include<stdio.h>
int main()
{
 int a[8] = {500, 100, 50, 20, 10, 5, 2, 1};
 int Amount, i, temp;
 
 printf("\n Please Enter the Amount of Cash  =  ");
 scanf("%d", &Amount);
 
 temp = Amount;
  
 for(i = 0; i < 8; i++)
 {
 	printf("\n %d Notes is = %d", a[i], temp / a[i]);
 	temp = temp % a[i];
 }
 printf(" Total amount = %d" , Amount);
 return 0;
}