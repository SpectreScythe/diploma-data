#include <stdio.h>

int main()
{
printf(“B=BURGER\nF=FRENCH FRY\nP=PIZZA\nS=SANDWICHES\n”);

char ss;
int n,x;
scanf(“%c”,&ss);

switch(ss)
{
case ‘B’:
scanf(“%d”,&n);
x= n*200;
printf(“Burger=Rs %d”,x);

case ‘F’:
scanf(“%d”,&n);
x= n*50;
printf(“Burger=Rs %d”,x);

case ‘P’:
scanf(“%d”,&n);
x= n*500;
printf(“Burger=Rs %d”,x);

case ‘S’:
scanf(“%d”,&n);
x= n*150;
printf(“Burger=Rs %d”,x);
}
}