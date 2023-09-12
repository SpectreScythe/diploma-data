#include <iostream>
using namespace std;

void TOH(int n, char x, char y, char z)
{
    if (n > 0)
    {
        TOH(n - 1, x, z, y);
        printf("\n%c -> %c", x, y);
        TOH(n - 1, z, y, x);
    }
}

int main()
{
    cout << "Tower Of Hanoi\n";
    int n;

    cout << "Enter No of Disks : ";
    cin >> n;

    TOH(n, 'A', 'B', 'C');
    return 0;
}