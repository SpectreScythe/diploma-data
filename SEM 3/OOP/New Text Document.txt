#include <iostream> 
using namespace std;
int main()
{
 int table = 9;
 int length = 10;
 int i = 1;

 cout << "Multiplication table: " << table;
 for(i=1; i<=length; i++)
  cout << "\n" << i << " * " <<  table << " = " << i * table;

 return 0;
}
