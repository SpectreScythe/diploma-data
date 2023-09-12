#include <stdio.h>
int main()
{
    int n, original, remainder, reverse=0;
    printf(" Enter n:");
    scanf("%d", &n);
    original = n;
    while (n != 0)
    {
        remainder = n % 10;
        reverse = reverse * 10 + remainder;
        n /= 10;
    }
    if (original == reverse)
    {
        printf("Palindrome");
    }
    else
    {
        printf("No");
    }

    return 0;
}