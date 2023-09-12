//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Header Files

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Tree Structure

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

typedef struct node
{
    int accno;
    int balance;
    char name[30];
    struct node *left, *right;
} node;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// New Noden Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *newNode(char *name, int accno)
{
    node *temp = (node *)malloc(sizeof(struct node));
    strcpy(temp->name, name);
    temp->balance = 500;
    temp->accno = accno;
    temp->left = temp->right = NULL;
    return temp;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Findin Smallestn Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *smallestBankAccNum(struct node *root)
{
    struct node *current = root;

    while (current && current->left != NULL)
        current = current->left;

    return current;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Deletin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *deleteACC(struct node *root, int accno)
{
    if (root == NULL)
        return root;

    if (accno < root->accno)
        root->left = deleteACC(root->left, accno);

    else if (accno > root->accno)
        root->right = deleteACC(root->right, accno);

    else
    {
        if (root->left == NULL)
        {
            struct node *temp = root->right;
            free(root);
            return temp;
        }
        else if (root->right == NULL)
        {
            struct node *temp = root->left;
            free(root);
            return temp;
        }

        struct node *temp = smallestBankAccNum(root->right);

        root->accno = temp->accno;

        root->right = deleteACC(root->right, temp->accno);
    }
    return root;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Insertin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *insert(struct node *root, char *name, int accno)
{

    if (root == NULL)
        return newNode(name, accno);

    if (accno < root->accno && accno != root->accno)
        root->left = insert(root->left, name, accno);
    else
        root->right = insert(root->right, name, accno);

    return root;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// In-Orderin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void inorder(struct node *root)
{
    if (root != NULL)
    {
        inorder(root->left);
        printf("\t\t\t%s\t\t\t\t%d\t\t\t\t%d\t\t\t\n\n\n", root->name, root->accno, root->balance);
        inorder(root->right);
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Post-Orderin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void preorder(struct node *root)
{
    if (root != NULL)
    {
        printf("\t\t\t%s\t\t\t\t%d\t\t\t\t%d\t\t\t\n\n\n", root->name, root->accno, root->balance);
        preorder(root->left);
        preorder(root->right);
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Pre-Orderin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void postorder(struct node *root)
{
    if (root != NULL)
    {
        postorder(root->left);
        postorder(root->right);
        printf("\t\t\t%s\t\t\t\t%d\t\t\t\t%d\t\t\t\n\n\n", root->name, root->accno, root->balance);
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Depostin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *deposit(node *root, int acc, int amt)
{
    node *temp;
    temp = root;
    if (temp == NULL)
    {
        printf("\n\t\t\t\t\t\tYou Haven't Created an account yet...\ntry creating an account\n\n");
        return NULL;
    }
    if (acc == temp->accno)
    {
        temp->balance += amt;
        return root;
    }
    else if (temp->accno > acc)
    {
        return deposit(root->left, acc, amt);
    }
    else
    {
        return deposit(root->right, acc, amt);
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Withdrawin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *withdraw(node *root, int acc, int amt)
{
    node *temp;
    temp = root;
    if (temp == NULL)
    {
        printf("\n\t\t\t\t\t\tYou Haven't Created an account yet...\ntry creating an account\n\n");
        return NULL;
    }
    if (acc == temp->accno)
    {
        if (acc <= 500)
        {
            printf("\n\t\t\t\t\t\tOperation Denied:Minimum Deposit amount should be $500");
            return 0;
        }
        else
        {
            temp->balance -= amt;
            return root;
        }
    }
    else if (temp->accno > acc)
    {
        return deposit(root->left, acc, amt);
    }
    else
    {
        return deposit(root->right, acc, amt);
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Menu Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

int menu()
{
    int chc;
    printf("\n\n------------------------------------------>   BANKING MANAGEMENT SYSTEM   <-----------------------------------------------");

    printf("\n\n\n-----------------------------------------[   WELCOME TO Omega Trust CORPS   ]---------------------------------------------\n\n\n");

    printf("\t\t\t\t\t\t1.Create an Account\n\t\t\t\t\t\t2.Delete an Account\n\t\t\t\t\t\t3.Deposit\n\t\t\t\t\t\t4.Withdrawal\n\t\t\t\t\t\t5.View Account\n\t\t\t\t\t\t6.Exit\n");

    printf("\n\n\t\t\t\t\t\tChoose An action = ");
    scanf("%d", &chc);

    return (chc);
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Project Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void DSU_PROJECT()
{
    system("color a");
    // system("font 32");

    node *root = NULL;
    int n, accno, del, chk, acc, acn, amt, amt2;
    char name[30];

A:

    n = menu();

    switch (n)

    {

    case 1:
        printf("\n\t\t\t\t\t\tEnter Your Name = ");
        scanf("%s", name);
        printf("\t\t\t\t\t\tEnter Account Number = ");
        scanf("%d", &accno);
        root = insert(root, name, accno);
        printf("\n\t\t\t\t\t<<<<Account Created Successfully>>>>\n");
        goto A;

    case 2:

        printf("\t\t\t\t\t\tEnter Account No = ");
        scanf("%d", &del);
        root = deleteACC(root, del);
        printf("\n\t\t\t\t\t<<<<Account Deleted Successfully>>>>\n");
        goto A;

    case 3:

        printf("\t\t\t\t\t\tEnter the Account Number = ");
        scanf("%d", &acc);
        printf("\t\t\t\t\t\tEnter the Amount to Deposit = ");
        scanf("%d", &amt);
        root = deposit(root, acc, amt);
        if (root != NULL)
        {
            printf("\t\t\t\t\t\tAccount holder = %s", root->name);
            printf("\n\t\t\t\t\t\tAccount Number = %d", root->accno);
            printf("\n\t\t\t\t\t\tAccount Balance = $%d", root->balance);
        }
        goto A;

    case 4:

        printf("\t\t\t\t\t\tEnter Account Number = ");
        scanf("%d", &acn);
        printf("\t\t\t\t\t\tEnter the Amount to Withdraw =$");
        scanf("%d", &amt2);
        root = withdraw(root, acn, amt2);
        if (root != NULL)
        {
            printf("\t\t\t\t\t\tAccount holder = %s", root->name);
            printf("\n\t\t\t\t\t\tAccount Number = %d", root->accno);
            printf("\n\t\t\t\t\t\tAccount Balance = $%d", root->balance);
        }
        goto A;

    case 5:

        printf("\n\t\t\t\t\t\t1.In-order\n\t\t\t\t\t\t2.Pre-order\n\t\t\t\t\t\t3.Post-order\n");
        printf("\t\t\t\t\t\tChoose an Action = ");
        scanf("%d", &chk);
        if (chk == 1)
        {
            printf("\n\t\t\t\t\tAccounts are Arranged in (in-order)\n ");
            printf("\t\t\t\t\t----------------------------------");
            printf("\n\t\t\t\t\t<<<<Account Details>>>>\n\n");
            printf("\n\n\n\t\t\tAccount Holder\t\t\tAccount Number\t\t\tAccount Balance\n\n\n");
            inorder(root);
        }
        else if (chk == 2)
        {
            printf("\n\t\t\t\t\tAccounts are Arranged in (Pre-order)\n ");
            printf("\t\t\t\t\t----------------------------------");
            printf("\n\t\t\t\t\t<<<<Account Details>>>>\n\n");
            printf("\n\n\n\t\t\tAccount Holder\t\t\tAccount Number\t\t\tAccount Balance\n\n\n");
            preorder(root);
        }
        else
        {
            printf("\n\t\t\t\t\tAccounts are Arranged in (Post-order)\n ");
            printf("\t\t\t\t\t----------------------------------");
            printf("\n\t\t\t\t\t<<<<Account Details>>>>\n\n");
            printf("\n\n\n\t\t\tAccount Holder\t\t\tAccount Number\t\t\tAccount Balance\n\n\n");
            postorder(root);
        }
        goto A;

    case 6:

        return 0;
    default:

        printf("\t\t\t\t\t\tInvalid Choice!!");
        goto A;
    }
    getch();
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Main Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

int main()
{
    DSU_PROJECT();
    return 0;
}