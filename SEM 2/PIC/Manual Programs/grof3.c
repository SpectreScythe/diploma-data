
#include <stdio.h>
void grof3(){
    int num1, num2, num3, largest;
    printf("Enter the first number: ");
    scanf("%d", &num1);
    printf("Enter the second number: ");
    scanf("%d", &num2);
    printf("Enter the third number: ");
    scanf("%d", &num3);
    largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
    printf("%d is the largest number.", largest);
}
int main(){
    grof3();
    return 0;
}