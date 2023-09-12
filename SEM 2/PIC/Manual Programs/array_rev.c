#include<stdio.h>
void array_rev(){
    int arr[100];
    int n;
    printf(" Enter value of N:");
    scanf("%d",&n);
    printf("\n Enter values for array[%d].\n",n);
    for(int i=0;i<n;i++){
        printf(" Value for [%d]:",i);
        scanf("%d",&arr[i]);
    }
    printf("\n The matrix is:\n");
    for(int i=0;i<n;i++){
            printf(" %d\n",arr[i]);
    }
    printf(" Reverse matrix:\n");
    for(int i=n-1;i>=0;i--){
        printf(" \n %d",arr[i]);
    }
}
int main(){
    array_rev();
    return 0;
}