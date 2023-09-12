#include <stdio.h>

int main() { 
   int n, number;
   int prime = 1;
   
   number = 11;

   for(n = 2; n < number; n++) {
      if((number % n) == 0) {
         prime = 0;
      }
   }

   if (prime == 1)
      printf("%d is prime number.", number);
   else
      printf("%d is not a prime number.", number);
   return 0;
}