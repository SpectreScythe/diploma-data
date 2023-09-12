#include<iostream>
#include <conio.h>
using namespace std;
class addition
{
    int x, y;

public:
    addition(int, int);
    void display();
};
addition::addition(int x1, int y1)
{
    x = x1;
    y = y1;
}
void addition::display()
{
    cout << "\nAddition of two numbers is:" << (x + y);
}
void main()
{
    addition a(3, 4);
    a.display();
    getch();
}
