#include <stdio.h>
void primatrix()
{
    int a[3][3], i, j;
    for (i = 0; i < 3; i++)
        for (j = 0; j < 3; j++)
        {
            printf("Enter Element at %d%d position", i + 1, j + 1);
            scanf("%d", &a[i][j]);
        }
    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 3; j++)
        {
            printf(" %d ", a[i][j]);
        }
        printf("\n");
    }
}
    void addmat()
    {
        int x, y, z, p, q, r, a, b, c;
        printf("enter any 9 numbers :\n");
        scanf("%d%d%d%d%d%d%d%d%d", &x, &y, &z, &p, &q, &r, &a, &b, &c);
        printf("%d %d %d\n", x, y, z);
        printf("%d %d %d\n", p, q, r);
        printf("%d %d %d\n", a, b, c);
        printf("Row total:%d %d %d\n", (x + y + z), (p + q + r), (a + b + c));
        printf("column total: %d %d %d\n", (x + p + a), (y + q + b), (z + r + c));
        printf("diagonal total :%d %d\n", (x + q + c), (a + q + z));
    }
int main()
{
    primatrix();
    addmat();
    return 0;
}