#include <stdio.h>
struct student
{
    char name[50];
    int roll_no;
    long int phone_no;
};
int main()
{

    int user_roll_no;
    struct student ABD = {
        "Abdurrahman Qureshi", // ABD.name
        51,                    // ABD.roll_no
        8879662240             // ABD.phone_no
    };
    ABD.roll_no = 51;
    printf(" Enter roll no of student:");
    scanf(" %d", &user_roll_no);
    if (user_roll_no == ABD.roll_no)
    {
        printf(" Name : \t %s\n", ABD.name);
        printf(" Roll No : \t %d\n", ABD.roll_no);
        printf(" Phone No : \t %ld\n", ABD.phone_no);
    }
    else
    {
        printf(" Data\tNot\tFound");
    }

    return 0;
}