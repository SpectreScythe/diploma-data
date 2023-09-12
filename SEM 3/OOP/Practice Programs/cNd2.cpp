#include<iostream>

using namespace std;

int val = 0;

class Test
{
    public:
    Test(){
        cout<< ++val;
    }
    ~Test(){
        cout<< val--;
    }
};

int main(){
    Test o1 , o2 , o3 ;
    {
        Test o4;
    }
    return 0;
}