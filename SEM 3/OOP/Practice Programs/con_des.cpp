
// #include <iostream>
// #include <conio.h>
// using namespace std;
// class number
// {
// public:
//     int x, y;
//     number(int a, int b)
//     {
//         x = a;
//         y = b;
//     }
//     void display()
//     {
//         cout << "X= " << x << endl;
//         cout << "Y= " << y << endl;
//         cout << "Addition of 2 nos: " << x + y << endl;
//         cout << "Subtraction of 2 nos: " << x - y << endl;
//         cout << "Product of 2 nos: " << x * y << endl;
//         cout << "Division of 2 nos: " << x / y << endl;
//     }
//     ~number()
//     {
//         cout << "Object destroyed";
//     }
// };

// int main()
// {
//     number o1(20, 12);
//     o1.display();
//     return 0;
// }

#include <iostream>
#include <conio.h>
using namespace std;
class product
{
public:
    int p_id, p_price;
    char *p_name; 
    product()
    {
        p_id = 0;
        p_price = 0;
        p_name = " ";
    }
    product(int a, int b, char *c)
    {
        p_id = a;
        p_price = b;
        p_name = c;
    }
    void putdata()
    {
        cout << "Product ID:" << p_id << endl;
        cout << "Product Price:" << p_price << endl;
        cout << "Product Name:" << p_name << endl;
    }
};
int main()
{
    int a, b, i;
    char *c;
    for (i = 0; i < 3; i++)
    {
        cout << "Enter details of the product:\n";
        cin >> a >> b >> c;
        product p1(a, b, c);
        p1.putdata();
    }
    return 0;
}
