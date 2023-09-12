#include<stdio.h>

void loader() {
    int i;
    char str[] = "                                        ";
    for(i = 0 ; i <= 40 ; i++) {
        printf("\r[%s]", str);
        str[i] = '|';
        sleep(100);
    }
}

int main(){
    loader();
    return 0;
}