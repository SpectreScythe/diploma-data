#include <iostream>

using namespace std;

class con
{
public:
    float area;
    con()
    {
        area = 0;
    }
    con(int a, int b)
    {
        area = a * b;
    }
    void dis()
    {
        cout<<area<<endl;
    }
};

int main()
{
    con o;
    con o2(10 , 20);
    o.dis();
    o2.dis();
    return 0;
}