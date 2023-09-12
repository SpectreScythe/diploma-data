#include<stdio.h>
void area_of_shapes(){
    int l_of_rectangle , b_of_rectangle;
    int area_of_rectangle , p_of_rectangle;
    printf(" Enter length and breadth of the rectangle:\n");
    printf(" Enter Length here:");
    scanf("%d",&l_of_rectangle);
    printf(" Enter Breadth here:");
    scanf("%d",&b_of_rectangle);
    area_of_rectangle = l_of_rectangle * b_of_rectangle;
    p_of_rectangle = l_of_rectangle + l_of_rectangle + b_of_rectangle + b_of_rectangle;
    printf(" Area = %d\n" , area_of_rectangle);
    printf(" Perimeter = %d" , p_of_rectangle);
}
int main(){
    area_of_shapes();
    return 0;
}