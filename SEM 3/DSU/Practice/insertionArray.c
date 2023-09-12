#include <stdio.h>

void insArr()
{
    int n, a[100];
    int newVal, pos;

    printf("\n\t\tEnter the number of array element:");
    scanf("%d", &n);

    for (int i = 0; i < n; i++)
    {
        printf("\n\t\tEnter element value at position[%d]:", i + 1);
        scanf("%d", &a[i]);
    }

    printf("\n\t\tOriginal Array:");

    for (int i = 0; i < n; i++)
    {
        printf("\n\t\tElement at position[%d] -> %d", i + 1, a[i]);
    }

    printf("\n\n\t\tEnter position to insert the new value:");
    scanf("%d", &pos);

    printf("\n\n\t\tEnter the value to be inserted:");
    scanf("%d", &newVal);

    n++;

    for (int i = n; i >= pos; --i)
    {
        a[i] = a[i - 1];
    }

    a[pos] = newVal;

    printf("\n\n\t\tNew Array:");

    for (int i = 0; i < n; i++)
    {
        printf("\n\t\tElement at position[%d] -> %d", i + 1, a[i]);
    }
}

int main()
{
    insArr();
    return 0;
}