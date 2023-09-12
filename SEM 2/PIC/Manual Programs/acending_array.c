#include <stdio.h>
#include <string.h>
int exam()
{
    int a[10];
    int temp;
    for(int i=0;i<10;i++){
        printf(" Enter elements of a[%d]:",i);
        scanf(" %d",&a[i]);
    }
    for(int i=0;i<10;i++){
        printf(" a[10] %d is %d\n",i,a[i]);
    }
    for(int i=0;i<10;i++){
        for(int j=i+1;j<10;j++){
            if(a[i]>a[j]){
                temp=a[i];
                a[i]=a[j];
                a[j]=temp;
            }
        }
    }
    printf(" Sorted a in acending order:\n");
    for(int i=0;i<10;i++){
        printf(" \n %d",a[i]);
    }
}
int main()
{
    exam();
    return 0;
}
