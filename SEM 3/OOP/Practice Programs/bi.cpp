#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>
#include <fstream>

using namespace std;

int main()
{
    ifstream ifile;
    char s[100], fname[20];
    char ch;
    cout << "\nEnter file name to read and display its content : ";
    cin >> fname;
    ifile.open(fname);
    if (!ifile)
    {
        cout << "\nFile does not exist..!!";
        cout << "\nWould you like to create the file?";
        cout << "\nPress 1 - YES \nPress 2 - NO";
        getchar() = ch;
        // ch = getchar();
        if (ch == 1)
        {
            ofstream MyFile(fname);
            cout << "File created....";
        }
        else if (ch == 2)
        {
            exit(0);
        }
    }
    else
    {
        while (ifile.eof() == 0)
        {
            ifile >> s;
            cout << s << " ";
        }
        cout << "\n";
    }
        ifile.close();
    return 0;
}
