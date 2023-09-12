#include<stdio.h>
void matrix3X3Sum(){

    int Mat1[3][3], Mat2[3][3], Sum[3][3];
    
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf(" Enter element in position [%d][%d]:" ,i+1,j+1);
            scanf("%d",&Mat1[i][j]);
        }
    }

    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf(" Enter element in position [%d][%d]:" ,i+1,j+1);
            scanf("%d",&Mat2[i][j]);
        }
    }

    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            Sum[i][j]=Mat1[i][j]+Mat2[i][j];
        }
    }

    printf(" Sum of the Matrices:\n");
    for(int i=0;i<3;i++){
        for(int j=0;j<3;j++){
            printf(" %d",Sum[i][j]);
        }
        printf("\n");
    }
}

int main(){
    matrix3X3Sum();
    return 0;
}