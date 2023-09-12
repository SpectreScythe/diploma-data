#include <stdio.h>
void season_by_month()
{
    int monno;
    printf("Input Month No : ");
    scanf("%d", &monno);
    switch (monno)
    {
    case 1:
        printf("January\n");
        printf("Winter\n");
        break;
    case 2:
        printf("February\n");
        printf("Winter\n");
        break;
    case 3:
        printf("March\n");
        printf("Autumn\n");
        break;
    case 4:
        printf("April\n");
        printf("Summer\n");
        break;
    case 5:
        printf("May\n");
        printf("Summer\n");
        break;
    case 6:
        printf("June\n");
        printf("Summer\n");
        break;
    case 7:
        printf("July\n");
        printf("Monsoon\n");
        break;
    case 8:
        printf("August\n");
        printf("Monsoon\n");
        break;
    case 9:
        printf("September\n");
        printf("Monsoon\n");
        break;
    case 10:
        printf("October\n");
        printf("Autumn\n");
        break;
    case 11:
        printf("November\n");
        printf("Winter\n");
        break;
    case 12:
        printf("December\n");
        printf("Winter\n");
        break;
    default:
        printf("invalid Month number. \nPlease try again ....\n");
        break;
    }
}
int main()
{
    season_by_month();
    return 0;
}