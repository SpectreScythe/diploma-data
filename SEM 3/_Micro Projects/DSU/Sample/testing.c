#include <stdio.h>
#include <time.h>
#include <conio.h>

#define MAX 999999

int main()
{
    int i;

    printf("\n Just a test with random numbers.");

    printf("\n ------------------------------------\n\n");

    srand(time(NULL));

    for(i = 0; i <1; i++)
    {
        printf(" %li\n", rand() % MAX+1);
    }

    printf("\n ====================================\n");
    return 0;
}