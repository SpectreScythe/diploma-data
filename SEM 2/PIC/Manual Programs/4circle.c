#include<stdio.h>
void circle(){
    float rad, area;
    float circumf;
    printf("Enter Radius Value of Circle: ");
    scanf("%f", &rad);
    area = 3.14*rad*rad;
    circumf = 2*3.14*rad;
    printf("\nArea = %0.2f", area);
    printf("\nCircumference = %0.2f", circumf);
}
int main()
{
    circle();
    return 0;
}