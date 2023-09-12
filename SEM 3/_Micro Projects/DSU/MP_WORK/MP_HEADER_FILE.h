//-------------------------------------------------------------------------------//

// Bank Management System - Micro Project

//-------------------------------------------------------------------------------//

// Header Files

//-------------------------------------------------------------------------------//

#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>

//-------------------------------------------------------------------------------//

// Global Declarations

//-------------------------------------------------------------------------------//

#define defAccountNUmber 84625

int randomNumber;
int userReadCustomerID;
char userReadCustomerName[50];
long int userReadCustomerPhoneNumber;
int userReadCustomerAmount;
int userReadCustomerBankBalance;

int confiramtionOne = 1;

//-------------------------------------------------------------------------------//

// Data type for User Info

//-------------------------------------------------------------------------------//

typedef struct
{
    int amount;
    int customerID;
    int bankBalance;
    long int accountNumber;
    long int phoneNumber;
    char customerName[30];
    char user[];
} USER;

//-------------------------------------------------------------------------------//

// Data type for BST

//-------------------------------------------------------------------------------//

typedef struct details
{
    USER details;
    struct user *rightChild;
    struct user *leftChild;
} USER_details;

USER_details *rootUserDetails = NULL;

//-------------------------------------------------------------------------------//

// Data type for address

//-------------------------------------------------------------------------------//

typedef struct
{
    int pincode;
    char customerAddress[200];
    struct addressLR *leftChild, *rightChild;
} Address;

Address *rootAddress = NULL;

//-------------------------------------------------------------------------------//

// Reading from BST and adding new user to tree

//-------------------------------------------------------------------------------//

void toDisplayList(USER_details *temp, USER_details *new)
{
    if (rootUserDetails == NULL)
    {
        rootUserDetails = new;
        return;
    }
    else if (temp->details.accountNumber > new->details.accountNumber)
    {
        if (temp->leftChild == NULL)
        {
            temp->leftChild = new;
            return;
        }
        else
        {
            toDisplayList(temp->rightChild, new);
        }
    }
    else
    {
        if (temp->rightChild == NULL)
        {
            temp->rightChild = new;
            return;
        }
        else
        {
            toDisplayList(temp->rightChild, new);
        }
    }
}

//-------------------------------------------------------------------------------//

// Checkin if the account number exists or not

//-------------------------------------------------------------------------------//

void validatingAccountNumber(USER_details *temp, long int userReadBankAccountNumber)
{
    if (temp == NULL)
    {
        return;
    }
    if (!confiramtionOne)
    {
        return;
    }
    if (temp->details.accountNumber == userReadBankAccountNumber)
        confiramtionOne = 0;
    validatingAccountNumber(temp->leftChild, userReadBankAccountNumber);
    validatingAccountNumber(temp->rightChild, userReadBankAccountNumber);
}

//-------------------------------------------------------------------------------//

// Generatin a account number randomly

//-------------------------------------------------------------------------------//

void Account_Number(USER_details *acc, USER_details *rootUserDetails)
{

a_c_c_o_u_n_t_n_u_m_b_e_r:

    long int x;
    x = 4 % 10000 + 10000;
    validatingAccountNumber(rootUserDetails, x);

    goto a_c_c_o_u_n_t_n_u_m_b_e_r;
}

//-------------------------------------------------------------------------------//

// Readin and Dislayin info

//-------------------------------------------------------------------------------//

USER_details *readAndDisplay()
{
    return rootUserDetails;
}

//-------------------------------------------------------------------------------//

// Checkin address for Pin Code

//-------------------------------------------------------------------------------//

void checkinAddressPinCode(int userReadPinCode, USER_details *acc, Address *temp)
{
    int a;

    if (temp == NULL)
    {
        return;
    }

    if (confiramtionOne != 1)
    {
        return;
    }

    checkinAddressPinCode(userReadPinCode, acc, temp->leftChild);
    checkinAddressPinCode(userReadPinCode, acc, temp->rightChild);

    if (temp->pincode == userReadPinCode && confiramtionOne == 1)
    {
        printf("is '%s' your address?", temp->customerAddress);
        printf("press '1' to confirm\npress '2' to check for another\npress '3' to enter by yourself\npress '4' enter another pincode\n");
        scanf("%d", &a);
        switch (a)
        {
        case 1:
            strcpy(acc->details., temp->customerAddress);
            acc->details.pinCode = pin;
            confiramtionOne = 0;
            break;
        case 2:
            break;
        case 3:
            confiramtionOne = 3;
            break;
        case 4:
            confiramtionOne = 4;
            break;
        }
    }
}

//-------------------------------------------------------------------------------//

// Chekin username

//-------------------------------------------------------------------------------//

void validatingUserName(USER_details *temp, char userName[])
{
    if (temp == NULL)
    {
        return;
    }

    if (!confiramtionOne)
    {
        return;
    }

    if (strcpy(temp->details.user, userName))
    confiramtionOne = 0;
    validatingUserName(temp->leftChild , userName);
    validatingUserName(temp->rightChild , userName);
}

//-------------------------------------------------------------------------------//

// Readin User Name

//-------------------------------------------------------------------------------//

void UserName(USER_details *acc , USER_details *rootUserDetails)
{
    char us[30];

    u_s_e_r_n_a_m_e:

    printf("Enter username:");
    scanf("%s" , us);

    confiramtionOne = 1;

    validatingUserName(rootUserDetails , us);

    if(confiramtionOne)
    {
        strcpy(acc->details.user , us);
    }
    
    else{
        printf("Username exists.Please try another Username\n");

        goto u_s_e_r_n_a_m_e;
    }
}

//-------------------------------------------------------------------------------//

// Creatin address tree

//-------------------------------------------------------------------------------//

void createadresstree(Address *temp, Address *new)
{
    if (rootAddress == NULL)
    {
        rootAddress = new;

        // printf("%s\n",roothead->Address );
        
        return;
    }
    if (temp->pincode > new->pincode)
    {
        if (temp->leftChild == NULL)
        {
            temp->leftChild = new;
            return;
        }
        else
            createadresstree(temp->leftChild, new);
    }
    else
    {
        if (temp->rightChild == NULL)
        {
            temp->rightChild = new;
            return;
        }
        else
            createadresstree(temp->rightChild, new);
    }
}

//-------------------------------------------------------------------------------//

// Creatin address tree

//-------------------------------------------------------------------------------//

USER_details *NEW_USER(USER_details *temp)
{
    rootUserDetails = temp;
    USER_details *new_ac;
    int t, pin;
    new_ac = (USER_details *)malloc(sizeof(USER_details));
    new_ac->leftChild = NULL;
    new_ac->rightChild = NULL;
    char A[20];
    printf("Please enter the details to Create a New Bank Account\n\n");
LOOP:
    printf("\tWhat Type of Account You want to open\n\t1.) Current \n\t2.) Saving\n\t3.) Fixed\n");
    scanf("%d", &t);
    switch (t)
    {
    case 1:
        printf("YOU HAVE SELECTED TO CREATE A CUREENT ACCOUNT\n");
        new_ac->details.Actype = 'C';
        new_ac->details.rateint = 8.26;
        break;
    case 2:
        printf("YOU HAVE SELECTED TO CREATE A SAVING ACCOUNT\n");
        new_ac->details.Actype = 'S';
        new_ac->details.rateint = 6.05;
        break;
    case 3:
        printf("YOU HAVE SELECTED TO CREATE A FIXED ACCOUNT\n");
        new_ac->details.Actype = 'F';
        new_ac->details.rateint = 4.90;
        break;
    default:
        printf("WRONG INPUT\n");
        goto LOOP;
    }
    printf("Enter Your Name\n");
    getchar();
    scanf("%[^\n]s", new_ac->details.NAME);
LOOP1:
    printf("Are You a\n 	1.) Male \n 	2.) Female\n 	3.) Others\n");
    scanf("%d", &t);
    switch (t)
    {
    case 1:
        new_ac->details.Gender = 'M';
        break;
    case 2:
        new_ac->details.Gender = 'F';
        break;
    case 3:
        new_ac->details.Gender = 'O';
        break;
    default:
        printf("WRONG INPUT\n");
        goto LOOP1;
    }
LOOP2:
    printf("Enter Your pincode\n");
    scanf("%d", &pin);
    confiramtionOne = 1;
    Address(pin, new_ac, h);
    if (confiramtionOne == 4)
    {
        goto LOOP2;
    }
    if (confiramtionOne == 3)
    {
        printf("Enter Your pincode\n");
        scanf("%d", &new_ac->details.pinCode);
        printf("Enter Your Address\n");
        getchar();
        scanf("%[^\n]s", new_ac->details.ADD);
    }
    if (confiramtionOne == 1)
    {
        printf("Sorry, unable to find address with same pin code\n");
        printf("Want To search for another Pin Code\nPress 1 to search\nPress any other key to enter address by self\n");
        scanf("%d", &pin);
        if (pin == 1)
            goto LOOP2;
        else
        {
            printf("Enter Your pincode\n");
            scanf("%d", &new_ac->details.pincode);
            printf("Enter Your Address\n");
            getchar();
            scanf("%[^\n]s", new_ac->details.ADD);
        }
    }
Loop3:
    printf("Enter Your 10 digit Mobile Number\n");
    scanf("%s", A);
    if (strlen(A) != 10)
    {
        printf("Invalid Phone No\n");
        goto Loop3;
    }
    else
        strcpy(new_ac->details.mob, A);
LOOP4:
    printf("Enter Your Email\n");
    scanf("%s", A);
    if (validating_email(A))
        strcpy(new_ac->details.Email, A);
    else
    {
        printf("Invalid Email Address\n");
        goto LOOP4;
    }
    printf("Enter Your OPENING Balance\n");
    scanf("%f", &new_ac->details.opbal);
    new_ac->details.Curbal = new_ac->details.opbal;
    Username(new_ac, roothead);
    addconferm = 1;
    passwordhide(new_ac);
    Account_No(new_ac, roothead);
    addconferm = 1;
    filetolist(roothead, new_ac);
    printf("\n");
    if (new_ac->details.Gender == 'M')
        printf("Thankyou MR. %s for connecting with us\n", new_ac->details.NAME);
    else if (new_ac->details.Gender == 'F')
        printf("Thankyou MISS. %s for connecting with us\n", new_ac->details.NAME);
    else
        printf("Thankyou %s for connecting with us\n", new_ac->details.NAME);
    printf("Your Account Number is '%d' \n", new_ac->details.AcNo);
    // roothead=EXISTING_USER(roothead,"11");
    return roothead;
}

//-------------------------------------------------------------------------------//

// Data type for address

//-------------------------------------------------------------------------------//

struct node *root;
struct node *createACC;

//-------------------------------------------------------------------------------//

// Creating a new node for a new account

//-------------------------------------------------------------------------------//

struct node *creatinAccount(int userReadCustomerAmount, int userReadCustomerID, int userReadCustomerBankBalance, char userReadCustomerName, long int userReadCustomerPhoneNumber)
{
    struct node *createACC;

    // printf("\n\t\t\t\t\t\t Enter Customer ID:");
    // scanf("%d", &userReadCustomerID);

    // printf("\n\t\t\t\t\t\t Enter Customer Name:");
    // scanf("%s", userReadCustomerName);

    // printf("\n\t\t\t\t\t\t Enter Customer Phone Number:");
    // scanf("%ld", &userReadCustomerPhoneNumber);

    // printf("\n\t\t\t\t\t\t Enter Deposit Amount:");
    // scanf("%d", &userReadCustomerAmount);

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

    insert(**root, accountNumber, userReadCustomerAmount, userReadCustomerID, userReadCustomerBankBalance, userReadCustomerName, userReadCustomerPhoneNumber);
    // return (createACC , userReadCustomerAmount , userReadCustomerID , userReadCustomerBankBalance , userReadCustomerName , userReadCustomerPhoneNumber);
}

//-------------------------------------------------------------------------------//

// Insertin the created node in the Binary Tree

//-------------------------------------------------------------------------------//

// struct node *insertinNode(struct node *root, struct node *createACC)
// {
//     if (root->accountNumber == NULL)
//     {
//         return creatinAccount(createACC , userReadCustomerAmount , userReadCustomerID , userReadCustomerBankBalance , userReadCustomerName , userReadCustomerPhoneNumber);
//     }
//     else if (createACC->accountNumber > root->accountNumber)
//     {
//         root->rightChild = insertinNode(root->rightChild, createACC);
//     }
//     else
//     {
//         root->leftChild = insertinNode(root->leftChild, createACC);
//     }
//     return (createACC);
// }

void insert(struct node **root, long int accountNumber, int userReadCustomerAmount, int userReadCustomerID, int userReadCustomerBankBalance, char userReadCustomerName, long int userReadCustomerPhoneNumber)
{
    struct node *temp = NULL;
    if (!(*root))
    {
        temp = (struct node *)malloc(sizeof(struct node));
        temp->leftChild = temp->rightChild = NULL;
        temp->accountNumber = accountNumber;
        temp->amount = userReadCustomerID;
        temp->phoneNumber = userReadCustomerPhoneNumber;
        strcpy(temp->customerName, userReadCustomerName);
        temp->amount = userReadCustomerAmount;
        temp->bankBalance = userReadCustomerBankBalance;
        *root = temp;
        return;
    }

    if (accountNumber < (*root)->accountNumber)
    {
        insert(&(*root)->leftChild, accountNumber, userReadCustomerAmount, userReadCustomerID, userReadCustomerBankBalance, userReadCustomerName, userReadCustomerPhoneNumber);
    }
    else if (accountNumber > (*root)->accountNumber)
    {
        insert(&(*root)->rightChild, accountNumber, userReadCustomerAmount, userReadCustomerID, userReadCustomerBankBalance, userReadCustomerName, userReadCustomerPhoneNumber);
    }
}

//-------------------------------------------------------------------------------//

// Findin the smallest in the Binary Tree

//-------------------------------------------------------------------------------//

struct node *smallestBankAccountNumber(struct node *root)
{
    if (root == NULL)
    {
        return NULL;
    }
    else if (root->leftChild != NULL)
    {
        return smallestBankAccountNumber(root->leftChild);
    }
    return root;
}

//-------------------------------------------------------------------------------//

// Searchin Account Function

//-------------------------------------------------------------------------------//

struct node *searchAndDisplayAccDetails(struct node *root, long int viewAccNumber)
{

    struct node *searchAndDisplay = root;
    char choiceDisplay[10];
    char y = "yes";
    char n = "no";

    if (root == NULL || root->accountNumber == viewAccNumber)
    {
        printf("\n\n\t\t\t\t\t\tNumber Found!!!");
        printf("\n\n\t\t\t\t\t\tWould you like to view details of the account?");

        printf("\n\t\t\t\t\t\tYes - To view details");
        printf("\n\t\t\t\t\t\tNo - To exit\n");

        scanf("%s", choiceDisplay);

        if (strcmpi(choiceDisplay, y) == 0)
        {
            printf("\n\n\t\t\t\t\t\tAccount number : %li", viewAccNumber);
            printf("\n\t\t\t\t\t\tAccount Name : %s", searchAndDisplay->customerName);
            printf("\n\t\t\t\t\t\tPhone Number : %ld", searchAndDisplay->phoneNumber);
            printf("\n\t\t\t\t\t\tAmount Deposited : %d", searchAndDisplay->amount);
            printf("\n\t\t\t\t\t\tBank Balance : %d", searchAndDisplay->bankBalance);
        }
        else
        {
            BankMenu();
        }
        return root;
    }
    else if (viewAccNumber > root->accountNumber)
    {
        return searchAndDisplayAccDetails(root->rightChild, viewAccNumber);
    }
    else
    {
        return searchAndDisplayAccDetails(root->leftChild, viewAccNumber);
    }
}

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

    printf("\n\n\n----------------------------------------------[   WELCOME TO DSU Bank   ]---------------------------------------------- \n");

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
    long int viewAccNumber;
    do
    {
        choice = input();
        switch (choice)
        {
        case 1:
            printf("\n\t\t\t\t\t\t Enter Customer ID:");
            scanf("%d", &userReadCustomerID);

            printf("\n\t\t\t\t\t\t Enter Customer Name:");
            scanf("%s", userReadCustomerName);

            printf("\n\t\t\t\t\t\t Enter Customer Phone Number:");
            scanf("%ld", &userReadCustomerPhoneNumber);

            printf("\n\t\t\t\t\t\t Enter Deposit Amount:");
            scanf("%d", &userReadCustomerAmount);
            userReadCustomerAmount = userReadCustomerBankBalance;
            creatinAccount(userReadCustomerAmount, userReadCustomerID, userReadCustomerName, userReadCustomerPhoneNumber, userReadCustomerBankBalance);
            break;
        case 2:
            editAccountDetails();
            break;
        case 3:
            runTransactions();
            break;
        case 4:
            printf("\n\t\t\t\t\t\tEnter your bank account number:");
            scanf("%ld", &viewAccNumber);
            searchAndDisplayAccDetails(root, viewAccNumber);
            break;
        case 5:
            printf("\n\t\t\t\t\t\tEnter your bank account number:");
            scanf("%ld", &delAccNumber);
            deleteAccount();
            break;
        case 6:
            endProgram();
            break;
        case 0:
            endProgram();
            break;
        default:
            printf("\n\t\t\t\t\t\tInvalid Choice!!!\n");
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