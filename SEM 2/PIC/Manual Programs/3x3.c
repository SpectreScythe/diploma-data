#include<stdio.h>
void matrix(){
    int m1[3][3],m2[3][3],sm[3][3];
    printf("--->Program for addition of 3 X 3 Matrix.\n\n");
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf(" Enter element for M1[%d][%d] is:",i+1,j+1);
            scanf(" %d",&m1[i][j]);
        }
    }
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf(" Enter element for M2[%d][%d] is:",i+1,j+1);
            scanf(" %d",&m2[i][j]);
        }
    }
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf("\n The element for M1[%d][%d] is: %d",i+1,j+1,m1[i][j]);
        }
    }
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf("\n The element for M2[%d][%d] is %d:",i+1,j+1,m2[i][j]);
        }
    }
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            sm[i][j]=m1[i][j]+m2[i][j];
        }
    }
    printf(" SUm of the two matrices are:\n");
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf(" %d",sm[i][j]);
        }
        printf("\n");
    }
}
int main(){
    matrix();
    return 0;
}