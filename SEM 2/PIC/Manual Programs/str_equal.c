#include<stdio.h>
#include<string.h>
void str_equal(){
    char str1[10],str2[10];
    printf(" Enter str1:");
    scanf("%s",str1);
    printf(" Enter str2:");
    scanf("%s",str2);
    if(strcmp(str1,str2)==0){
        printf(" They are equal.\n");
    }
    else{
        printf(" They are unequal.\n");
    }
}
int main(){
    str_equal();
    return 0;
}