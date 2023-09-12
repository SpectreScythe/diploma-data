#include<stdio.h>
int rev=0,rem;
reverse(int num){
   if(num){
      rem=num%10;
      rev=rev*10+rem;
      reverse(num/10);
   }
   else
      return rev;
}
int main(){
   int num,revs;

   printf("\nEnter any number:");
   scanf("%d",&num);
   revs=reverse(num);
   printf("\nAfter reverse the no is :%d",revs);
   return 0;
}