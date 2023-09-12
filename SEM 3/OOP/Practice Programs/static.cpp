// C++ program to Count the number of objects
// using the Static member function
#include <iostream>
using namespace std;
class test
{
    static int count;
    int obj_no;

public:
    void getdata()
    {
        obj_no = ++count;
        cout << "\n Object number=" << obj_no;
    }
    static void showcount()
    {
        cout << "\n total number of objects=" << count;
    }
};
int test::count;

int main()
{
    test t1, t2;
    t1.getdata();
    t2.getdata();
    test::showcount();
    test t3;
    t3.getdata();
    test::showcount();

    return 0;
}
