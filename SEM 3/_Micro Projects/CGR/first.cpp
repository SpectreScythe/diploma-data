#include<stdio.h>
#include<graphics.h>

int main(){
    int gd = DETECT,gm;
    initgraph(&gd,&gm,"");
    rectangle(300,300,500,500);
    return 0;
}