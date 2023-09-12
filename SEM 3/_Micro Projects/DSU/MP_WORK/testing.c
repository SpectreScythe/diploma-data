#include <stdio.h>
#include <string.h>

#define defAccountNUmber 39576

int randomNumber;
int userReadCustomerID;
char userReadCustomerName[50];
long int userReadCustomerPhoneNumber;
int userReadCustomerAmount;

struct node
{
    int amount;
    int customerID;
    int bankBalance;
    long int accountNumber;
    long int phoneNumber;
    char customerName[30];

    struct node *rightChild;
    struct node *leftChild;
};

struct node *root;
struct node *createACC;

void menu();
void endProgram();
void createAccount();
void deleteAccount();
void runTransactions();
void editAccountDetails();
void viewAccountDetails();
void displayAccountDetails();

//-------------------------------------------------------------------------------//

// Edit Account Details Functions

//-------------------------------------------------------------------------------//

void editAccountDetails()
{
}

//-------------------------------------------------------------------------------//

// Display Account Details Functions

//-------------------------------------------------------------------------------//

void displayAccountDetails()
{
}

//-------------------------------------------------------------------------------//

// Transactions Functions

//-------------------------------------------------------------------------------//

void runTransactions()
{
}

//-------------------------------------------------------------------------------//

// Delete Program Functions

//-------------------------------------------------------------------------------//

void deleteAccount()
{
}

//-------------------------------------------------------------------------------//

// View Account Details Functions

//-------------------------------------------------------------------------------//

void viewAccountDetails()
{
}

//-------------------------------------------------------------------------------//

// End Program Functions

//-------------------------------------------------------------------------------//

void endProgram()
{
    printf("\n\n\n\t\t  This Project was developed by 210451.");
    printf("\n\t\t  Thanks for checking out my program");
}

struct node *creatinAccount()
{
    struct node *createACC;

    printf("\n\t\t\t\t\t\tEnter Customer ID:");
    scanf("%d", &userReadCustomerID);

    printf("\n\t\t\t\t\t\tEnter Customer Name:");
    scanf("%s", userReadCustomerName);

    printf("\n\t\t\t\t\t\tEnter Customer Phone Number:");
    scanf("%ld", &userReadCustomerPhoneNumber);

    printf("\n\t\t\t\t\t\tEnter Deposit Amount:");
    scanf("%d", &userReadCustomerAmount);

    createACC = (struct node *)malloc(sizeof(struct node));

    createACC->amount = userReadCustomerAmount;
    createACC->bankBalance = createACC->amount;
    createACC->customerID = userReadCustomerID;
    strcpy(createACC->customerName, userReadCustomerName);
    createACC->phoneNumber = userReadCustomerPhoneNumber;
    createACC->rightChild = NULL;
    createACC->leftChild = NULL;

    printf("\n\n\t\t\t\t\t---------------Account Created---------------");

    createACC->accountNumber = defAccountNUmber + 4;
    printf("\n\n\t\t\t\t\t\tAccount number : %li", createACC->accountNumber);
    printf("\n\t\t\t\t\t\tAccount Name : %s", createACC->customerName);
    printf("\n\t\t\t\t\t\tPhone Number : %ld", createACC->phoneNumber);
    printf("\n\t\t\t\t\t\tAmount Deposited : %d", createACC->amount);
    printf("\n\t\t\t\t\t\tBank Balance : %d", createACC->bankBalance);

    return (createACC);
}

// struct node *viewAccountDetails(*createACC)
// {

// }

int input()
{
    int number;
    printf("\n\n------------------------------------------>   BANKING MANAGEMENT SYSTEM   <---------------------------------------------");

    printf("\n\n\n----------------------------------------------[   WELCOME TO Axis Bank   ]---------------------------------------------- \n");

    printf("\n\t\t\t\t\t\t 1.Create new account");
    printf("\n\t\t\t\t\t\t 2.Update information of existing account");
    printf("\n\t\t\t\t\t\t 3.For transactions");
    printf("\n\t\t\t\t\t\t 4.Check the details of existing account");
    printf("\n\t\t\t\t\t\t 5.Delete existing account");
    printf("\n\t\t\t\t\t\t 6.View customer's list");
    printf("\n\t\t\t\t\t\t 7.Exit");

    printf("\n\n\t\t\t\t\t\t Enter your choice:");
    scanf("%d", &number);
    return (number);
}

int main()
{
    int choice;
    long int delAccNumber;
    do
    {
        choice = input();
        switch (choice)
        {
        case 1:
            creatinAccount();
            break;
        case 2:
            editAccountDetails();
            break;
        case 3:
            runTransactions();
            break;
        case 4:
            displayAccountDetails();
            break;
        case 5:
            printf("Enter your bank account number:");
            scanf("%ld", &delAccNumber);
            deleteAccount();
            break;
        case 6:
            viewAccountDetails();
            break;
        case 0:
            endProgram();
            break;
        default:
            printf("\n\t\t\t Invalid Choice!!!\n");
            break;
        }
    } while (choice != 0);
    return 0;
}
