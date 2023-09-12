#include <stdio.h>
#include<conio.h>
void
type_of_triangle () 
{
  
int flag;
  
float a, b, c, s;
  
 
printf ("Enter sides of a triangle: \n");
  
 
printf (" a: ");
  
scanf ("%f", &a);
  
printf (" b: ");
  
scanf ("%f", &b);
  
printf (" c: ");
  
scanf ("%f", &c);
  
  {
    
if ((a == b) && (b == c))
      
      {
	
flag = 100;
      
}
    
    else if ((a == b) || (b == c) || (a == c))
      
      {
	
flag = 200;
      
}
    
    else
      
      {
	
flag = 300;
      
}
    
switch (flag)
      
      {
      
case 100:
	
printf (" The triangle is an equilateral triangle.");
	
break;
      
case 200:
	
printf (" The triangle is an isoceles triangle.");
	
break;
      
case 300:
	
printf (" The triangle is an scalene triangle.");
	
break;
      
 
}
  
}

}


int
main () 
{
  
type_of_triangle ();
  
return 0;

getch();
}


