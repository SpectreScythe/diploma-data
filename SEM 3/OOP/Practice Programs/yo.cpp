#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    char data[100];
    ofstream fout;
    fout.open("FileHandling.txt");

    cout << "Writing To The File..." << endl;
    cout << "Enter Name : ";

    cin.getline(data, 100);
    fout << data << endl;

    cout << "Enter Roll No : ";
    cin >> data;
    cin.ignore();

    fout << data;
    fout.close();

    ifstream fin;
    fin.open("FileHandling.txt");
    cout << endl
         << "Reading From The File..." << endl;

    fin >> data;
    cout << data << endl;

    fin >> data;
    cout << data << endl;
    fin.close();

    return 0;
}
// #include <iostream>
// #include <fstream>
// #include <string.h>
// #include <stdlib.h>
// using namespace std;

// int main()
// {
//     ifstream in;
//     ofstream out;
//     char str[50], f1[50], read[50];
//     system("cls");
//     cout<<"Enter the string: ";
//      gets(str);
//     cout<<"Enter the file name: ";
//     gets(f1);
//      out.open("hello.txt");
//      out<<str;
//      out.close();
//     cout<<"Reading from: "<<"hello.txt"<<endl;
//     in.open("hello");
//     if (in.file_open())
//     {
//         while (!in.eof())
//         {
//             in.getline(read, sizeof(read));
//             cout << read << endl;
//             ;
//         }
//         in.close();
//     }
//     else
//         cout << "File does not exist";
//     return 0;
// }