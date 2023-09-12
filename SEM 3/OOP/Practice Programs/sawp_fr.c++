#include <iostream>
#include <conio.h>
#include<stdio.h>
//#include<conio.h>
using namespace std;

class B;
class A
{
    int x;

public:
    void accept()
    {
        cout << "\n Enter the value for x:";
        cin >> x;
    }
    friend void swap(A, B);
};
class B
{
    int y;

public:
    void accept()
    {
        cout << "\n Enter the value for y:";
        cin >> y;
    }
    friend void swap(A, B);
};
void swap(A a, B b)
{
    cout << "\n Before swapping:";
    cout << "\n Value for x=" << a.x;
    cout << "\n Value for y=" << b.y;
    int temp;
    temp = a.x;
    a.x = b.y;
    b.y = temp;
    cout << "\n After swapping:";
    cout << "\n Value for x=" << a.x;
    cout << "\n Value for y=" << b.y;
}
int main()
{
    A a;
    B b;
    //clrscr();
    a.accept();
    b.accept();
    swap(a, b);
    return 0;
}
