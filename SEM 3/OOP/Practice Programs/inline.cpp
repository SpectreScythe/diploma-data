#include <iostream>
#include <conio.h>
using namespace std;
class number
{
public:
    int x, y;
    inline void getdata();
    inline void putdata();
};
inline void number::getdata()
{
    cout << "Enter value of x and y:";
    cin >> x >> y;
}
inline void number::putdata()
{
    cout << "X= " << x << endl;
    cout << "Y= " << y << endl;
    cout << "Addition of 2 nos: " << x + y << endl;
    cout << "Subtraction of 2 nos: " << x - y << endl;
    cout << "Product of 2 nos: " << x * y << endl;
    cout << "Division of 2 nos: " << x / y << endl;
}
int main()
{
    number o1;
    o1.getdata();
    o1.putdata();
    return 0;
}
