//-------------------------------------------------------------------------------//

// Bank Management System - Micro Project

//-------------------------------------------------------------------------------//

// Header Files

//-------------------------------------------------------------------------------//

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

//-------------------------------------------------------------------------------//

// Global Declarations

//-------------------------------------------------------------------------------//

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

//-------------------------------------------------------------------------------//

// Creating a new node for a new account

//-------------------------------------------------------------------------------//

struct node *creatinAccount()
{
    struct node *createACC;

    printf("\n\t\t\t\t\t\t Enter Customer ID:");
    scanf("%d", &userReadCustomerID);

    printf("\n\t\t\t\t\t\t Enter Customer Name:");
    scanf("%s", userReadCustomerName);

    printf("\n\t\t\t\t\t\t Enter Customer Phone Number:");
    scanf("%ld", &userReadCustomerPhoneNumber);

    printf("\n\t\t\t\t\t\t Enter Deposit Amount:");
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

// //-------------------------------------------------------------------------------//

// // Insertin the created node in the Binary Tree

// //-------------------------------------------------------------------------------//

// struct node *insertinNode(struct node *root, struct node *creatACC)
// {
//     if (root->accountNumber == NULL)
//     {
//         return creatinAccount(createACC);
//     }
//     else if (createACC->accountNumber > root->accountNumber)
//     {
//         root->rightChild = insertinNode(root->rightChild, creatACC);
//     }
//     else
//     {
//         root->leftChild = insertinNode(root->leftChild, creatACC);
//     }
// }

// //-------------------------------------------------------------------------------//

// // Insertin the created node in the Binary Tree

// //-------------------------------------------------------------------------------//

// struct node *smallestBankAccountNumber(struct node *root)
// {
//     if (root == NULL)
//     {
//         return NULL;
//     }
//     else if (root->leftChild != NULL)
//     {
//         return smallestBankAccountNumber(root->leftChild);
//     }
//     return root;
// }

// //-------------------------------------------------------------------------------//

// // Searchin Account Function

// //-------------------------------------------------------------------------------//

// struct node *search(struct node *root)
// {
//     long int toSearchAccountNumber;

//     printf("Enter your bank account number:");
//     scanf("%ld", &toSearchAccountNumber);

//     if (root == NULL || root->accountNumber == toSearchAccountNumber)
//     {
//         return root;
//     }
//     else if (toSearchAccountNumber > root->accountNumber)
//     {
//         return search(root->rightChild);
//     }
//     else
//     {
//         return search(root->leftChild);
//     }
// }

// //-------------------------------------------------------------------------------//

// // Inorderin Function

// //-------------------------------------------------------------------------------//

// void inorder(struct node *root)
// {
//     if (root != NULL)
//     {
//         inorder(root->leftChild);
//         printf(" %ld ", root->accountNumber);
//         inorder(root->rightChild);
//     }
// }

// //-------------------------------------------------------------------------------//

// // Deletin Function

// //-------------------------------------------------------------------------------//

// struct node *deleteAcc(struct node *root, long int delAccNum)
// {
//     if (root == NULL)
//         return NULL;
//     if (delAccNum > root->accountNumber)
//         root->rightChild = delete (root->rightChild);
//     else if (delAccNum < root->accountNumber)
//         root->leftChild = delete (root->leftChild);
//     else
//     {
//         if (root->leftChild == NULL && root->rightChild == NULL)
//         {
//             free(root);
//             return NULL;
//         }

//         else if (root->leftChild == NULL || root->rightChild == NULL)
//         {
//             struct node *temp;
//             if (root->leftChild == NULL)
//                 temp = root->rightChild;
//             else
//                 temp = root->leftChild;
//             free(root);
//             return temp;
//         }

//         else
//         {
//             struct node *temp = find_minimum(root->rightChild);
//             root->accountNumber = temp->accountNumber;
//             root->rightChild = delete (root->rightChild, temp->accountNumber);
//         }
//     }
//     return root;
// }

//-------------------------------------------------------------------------------//

// Global Function Declarations

//-------------------------------------------------------------------------------//

void menu();
void endProgram();
void createAccount();
void deleteAccount();
void runTransactions();
void editAccountDetails();
void viewAccountDetails();
void displayAccountDetails();

//-------------------------------------------------------------------------------//

// Menu Function

//-------------------------------------------------------------------------------//

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

int BankMenu()
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

/*-------------------------------------------------------------------------------/

    // Program End

/-------------------------------------------------------------------------------*/

int main()
{
    BankMenu();
    return 0;
}

//-------------------------------------------------------------------------------//