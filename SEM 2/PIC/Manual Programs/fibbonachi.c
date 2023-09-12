#include <stdio.h>
#include <string.h>
int exam()
{
    int n;
    int f_num=0, s_num=1, t_num;
    printf(" Enter a number:");
    scanf("%d",&n);
    printf(" First two = %d\t%d",f_num,s_num);
    for(int i=2;i<n;i++){
        t_num = f_num+s_num;
        printf("%d\t",t_num);
        f_num=s_num;
        s_num=t_num;
    }
}
int main()
{
    exam();
    return 0;
}