#include <stdio.h>
void sumofdigits()
{
    int n, sum = 0;
    printf("Enter a number: ");
    scanf("%d", &n);
    for (; n > 0; sum += n % 10, n /= 10)
    {
    }
    printf("The sum of digits: %d", sum);
}
int main()
{
    sumofdigits();
    return 0;
}