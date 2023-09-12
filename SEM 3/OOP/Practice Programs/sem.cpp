#include <fstream>
#include <iostream>
#include <stdlib.h>

using namespace std;

int main()
{
    ifstream fin("abc.txt");
    ofstream fout("xyz.txt");
    
    fout << fin.rdbuf();
    
    return 0;
}