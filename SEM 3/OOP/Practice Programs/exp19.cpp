#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <fstream>
using namespace std;
int main()
{
    ifstream ifiles1, ifiles2;
    ofstream ifilet;
    char ch, fname1[20], fname2[20], fname3[30];
    cout << "\nEnter the fisrt file name:";
    gets(fname1);
    cout << "Enter the second file name:";
    gets(fname2);
    cout << "Enter the third file name:";
    gets(fname3);
    ifiles1.open(fname1);
    ifiles2.open(fname2);
    if (ifiles1 == NULL || ifiles2 == NULL)
    {
        perror("error msg");
        cout << "Press any key to exit\n";
        getch();
        exit(EXIT_FAILURE);
    }
    ifilet.open(fname3);
    if (!ifilet)
    {
        perror("error msg");
        cout << "Press any key to exit\n";
        getch();
        exit(EXIT_FAILURE);
    }
    while (ifiles1.eof() == 0)
    {
        ifiles1 >> ch;
        ifilet << ch;
    }
    while (ifiles2.eof() == 0)
    {
        ifiles2 >> ch;
        ifilet << ch;
    }
    cout << "\nTwo files were merged into " << fname3 << " file successfully..!!";
    ifiles1.close();
    ifiles2.close();
    ifilet.close();
    return 0;
}
