
// Deleting an element in an array

#include <iostream>
#include <stdio.h>
using namespace std;
void deletion()
{
    int a[50], n, pos, ue;
    cout << "\n Enter number of elements for the array:";
    cin >> n;
    cout << "\n";
    for (int i = 0; i < n; i++)
    {
        cout << " Enter element here:";
        cin >> a[i];
    }
    cout << "\n";
    for (int i = 0; i < n; i++)
    {
        cout << " The array is:" << a[i] << "\n";
    }
    cout << "\n";
    cout << " Enter position to be deleted:";
    cin >> pos;
    if (pos <= n - 1)
    {
        for (int i = pos - 1; i <= n - 1; i++)
        {                    // shift elements backwards
            a[i] = a[i + 1]; // deleting the index
            n--;
        }
    }
    else
    {
        cout << "Index not present";
    }
    cout << "\n";
    for (int i = 0; i < n; i++)
    {
        cout << " After Deletion - The array is:" << a[i] << "\n";
    }
}
int main()
{
    deletion();
    return 0;
}