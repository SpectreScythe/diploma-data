#include <stdio.h>

int main()
{
    struct student
    {
        int roll_no;
        int marks;
        char name_of_student[50];
    } s[3];

    for (int i = 1; i <= 3; i++)
    {
        printf("\n Data for student %d:", i);

        printf("\n\n Enter roll no of student %d:", i);
        scanf("%d", &s[i].roll_no);
        printf("\n Enter marks of student %d:", i);
        scanf("%d", &s[i].marks);
        printf("\n Enter name of student of student %d:", i);
        scanf("%s", s[i].name_of_student);
    }
        printf("\n Entered data for the students is:");
    for (int i = 1; i <= 3; i++)
    {

        printf("\n\n The roll no of student %d is %d", i, s[i].roll_no);
        printf("\n The marks of student %d is %d", i, s[i].marks);
        printf("\n The name of student of student %d is %s\n\n", i, s[i].name_of_student);
    }

    return 0;
}