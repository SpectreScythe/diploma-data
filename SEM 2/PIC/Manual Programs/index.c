#include <stdio.h>
void choices()
{
    printf(" C Programs Mash-Up.\n\n");
    printf(" Enter any number from 1 to 7.\n");
    printf(" 1 - Sum and Average of N numbers.\n");
    printf(" 2 - LCM and HCF of two positive numbers.\n");
    printf(" 3 - Factorial of N number.\n");
    printf(" 4 - Fibonacchi of N number.\n");
    printf(" 5 - To print all Prime numbers from 1 to N number.\n");
    printf(" 6 - To check if N is an Armstrong number.\n");
    printf(" 7 - Exit\n");
}

void switchStatement()
{
    char ch;
    scanf("%d", &ch);
    switch (ch)
    {

        //Sum and Average of N numbers

    case 1:
        printf(" 1 - Sum and Average of N numbers.\n ");
        int s1_i, s1_n, s1_Sum = 0, s1_numbers;
        float Average;
        printf("\nEnter the Number\n");
        scanf("%d", &s1_n);
        printf("\nEnter the Number Step by Step\n");
        for (s1_i = 0; s1_i < s1_n; ++s1_i)
        {
            scanf("%d", &s1_numbers);
            s1_Sum = s1_Sum + s1_numbers;
        }
        Average = s1_Sum / s1_n;
        printf("\nSum of the %d Numbers = %d", s1_n, s1_Sum);
        printf("\nAverage of the %d Numbers = %.2f", s1_n, Average);
        break;

        //LCM and HCF of two positive numbers

    case 2:
        printf(" 2 - LCM and HCF of two positive numbers.\n");
        int s2_num1, s2_num2, s2_mp;
        printf("Enter two Numbers: ");
        scanf("%d %d", &s2_num1, &s2_num2);
        if (s2_num1 > s2_num2)
            s2_mp = s2_num1;
        else
            s2_mp = s2_num2;
        while (1)
        {
            if ((s2_mp % s2_num1 == 0) && (s2_mp % s2_num2 == 0))
                break;
            else
                s2_mp++;
        }
        printf("\nLCM(%d,%d) = %d", s2_num1, s2_num2, s2_mp);
        break;

        //Factorial of N number

    case 3:
        printf(" 3 - Factorial of N number.\n");
        int s3_i, s3_fact = 1, s3_number;
        printf("Enter a number: ");
        scanf("%d", &s3_number);
        for (s3_i = 1; s3_i <= s3_number; s3_i++)
        {
            s3_fact = s3_fact * s3_i;
        }
        printf("Factorial of %d is: %d", s3_number, s3_fact);
        break;

        //Fibonacchi of N number

    case 4:
        printf(" 4 - Fibonacchi of N number.\n");
        int s4_n, s4_nbr1 = 0, s4_nbr2 = 1, s4_next, s4_i;

        printf("Enter the number of terms: ");
        scanf("%d", &s4_n);

        printf("The first %d terms of the Fibonacci series are: \n", s4_n);

        for (s4_i = 0; s4_i < s4_n; s4_i++)
        {
            if (s4_i <= 1)
                s4_next = s4_i;
            else
            {
                s4_next = s4_nbr1 + s4_nbr2;
                s4_nbr1 = s4_nbr2;
                s4_nbr2 = s4_next;
            }
            printf("%d\n", s4_next);
        }
        break;

        //To print all Prime numbers from 1 to N number

    case 5:
        printf(" 5 - To print all Prime numbers from 1 to N number.\n");
        int s5_i, s5_j, s5_end, s5_isPrime;
        printf("Find prime numbers between 1 to : ");
        scanf("%d", &s5_end);
        printf("All prime numbers between 1 to %d are:\n", s5_end);
        for (s5_i = 2; s5_i <= s5_end; s5_i++)
        {
            s5_isPrime = 1;
            for (s5_j = 2; s5_j <= s5_i / 2; s5_j++)
            {
                if (s5_i % s5_j == 0)
                {
                    s5_isPrime = 0;
                    break;
                }
            }
            if (s5_isPrime == 1)
            {
                printf("%d, ", s5_i);
            }
        }
        break;

        //To check if N is an Armstrong number

    case 6:
        printf(" 6 - To check if N is an Armstrong number.\n");
        int s6_num, s6_originalNum, s6_remainder, s6_result = 0;
        printf("Enter a three-digit integer: ");
        scanf("%d", &s6_num);
        s6_originalNum = s6_num;
        while (s6_originalNum != 0)
        {
            s6_remainder = s6_originalNum % 10;
            s6_result += s6_remainder * s6_remainder * s6_remainder;
            s6_originalNum /= 10;
        }
        if (s6_result == s6_num)
            printf("%d is an Armstrong number.", s6_num);
        else
            printf("%d is not an Armstrong number.", s6_num);
        break;

    case 7:
        printf(" 7 - Exit\n");
        break;
    }
}

int main()
{
    choices();
    switchStatement();
    return 0;
}