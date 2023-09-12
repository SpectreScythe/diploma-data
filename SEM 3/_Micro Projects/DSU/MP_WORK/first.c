#include <stdlib.h>
#include <stdio.h>

#define defAccountNUmber 84625

int userReadCustomerID;
int userReadCustomerAmount;
int userReadCustomerBankBalance;
long int userReadAccountNumber;
long int userReadCustomerPhoneNumber;
char userReadCustomerName[50];

struct bin_tree
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
typedef struct bin_tree node;

void insert(node **tree, int userReadCustomerAmount, int userReadCustomerID, int userReadCustomerBankBalance, char userReadCustomerName, long int userReadCustomerPhoneNumber)
{
    node *temp = NULL;
    if (!(*tree))
    {
        temp = (struct node *)malloc(sizeof(node));
        temp->leftChild = temp->rightChild = NULL;
        temp->accountNumber = userReadAccountNumber;
        temp->amount = userReadCustomerID;
        temp->phoneNumber = userReadCustomerPhoneNumber;
        strcpy(temp->customerName, userReadCustomerName);
        temp->amount = userReadCustomerAmount;
        temp->bankBalance = userReadCustomerBankBalance;
        *tree = temp;
        return;
    }

    if ( userReadAccountNumber < (*tree)->accountNumber)
    {
        insert(&(*tree)->leftChild, userReadCustomerAmount, userReadCustomerID, userReadCustomerBankBalance, userReadCustomerName, userReadCustomerPhoneNumber);
    }
    else if (userReadAccountNumber > (*tree)->accountNumber)
    {
        insert(&(*tree)->rightChild, userReadCustomerAmount, userReadCustomerID, userReadCustomerBankBalance, userReadCustomerName, userReadCustomerPhoneNumber);
    }
}

/*------------------------------------------------------------------------------------------------------*/

// void print_preorder(node *tree)
// {
//     if (tree)
//     {
//         printf("%d\n", tree->data);
//         print_preorder(tree->leftChild);
//         print_preorder(tree->rightChild);
//     }
// }

// void print_postorder(node *tree)
// {
//     if (tree)
//     {
//         print_postorder(tree->leftChild);
//         print_postorder(tree->rightChild);
//         printf("%d\n", tree->data);
//     }
// }

/*------------------------------------------------------------------------------------------------------*/

void print_inorder(node *tree)
{
    if (tree)
    {
        print_inorder(tree->leftChild);
        printf("%d\n", tree->accountNumber);
        printf("%d\n", tree->bankBalance);
        printf("%d\n", tree->customerName);
        printf("%d\n", tree->phoneNumber);
        printf("%d\n", tree->customerID);
        print_inorder(tree->rightChild);
    }
}

void deltree(node *tree)
{
    if (tree)
    {
        deltree(tree->leftChild);
        deltree(tree->rightChild);
        free(tree);
    }
}

node *search(node **tree, long int userReadAccountNumber)
{
    if (!(*tree))
    {
        return NULL;
    }

    if (userReadAccountNumber < (*tree)->accountNumber)
    {
        search(&((*tree)->leftChild), userReadAccountNumber);
    }
    else if (userReadAccountNumber > (*tree)->accountNumber)
    {
        search(&((*tree)->rightChild), userReadAccountNumber);
    }
    else if (userReadAccountNumber == (*tree)->accountNumber)
    {
        return *tree;
    }
}

void main()
{
    node *root;
    node *tmp;
    // int i;

    root = NULL;
    /* Inserting nodes into tree */
    printf("\n\t\t\t\t\t\t Enter Customer ID:");
    scanf("%d", &userReadCustomerID);

    printf("\n\t\t\t\t\t\t Enter Customer Name:");
    scanf("%s", userReadCustomerName);

    printf("\n\t\t\t\t\t\t Enter Customer Phone Number:");
    scanf("%ld", &userReadCustomerPhoneNumber);

    printf("\n\t\t\t\t\t\t Enter Deposit Amount:");
    scanf("%d", &userReadCustomerAmount);

    userReadCustomerAmount = userReadCustomerBankBalance;

    insert(&root, userReadCustomerAmount, userReadCustomerBankBalance, userReadCustomerID, userReadCustomerName, userReadCustomerPhoneNumber);
    // insert(&root, userReadCustomerAmount, userReadCustomerBankBalance, userReadCustomerID, userReadCustomerName, userReadCustomerPhoneNumber);
    // insert(&root, 15);
    // insert(&root, 6);
    // insert(&root, 12);
    // insert(&root, 17);
    // insert(&root, 2);

    /* Printing nodes of tree */
    // printf("Pre Order Display\n");
    // print_preorder(root);

    printf("In Order Display\n");
    print_inorder(root);

    // printf("Post Order Display\n");
    // print_postorder(root);

    /* Search node into tree */
    tmp = search(&root, 4);
    if (tmp)
    {
        printf("Searched node=%d\n", tmp->accountNumber);
    }
    else
    {
        printf("Data Not found in tree.\n");
    }

    /* Deleting all nodes of tree */
    deltree(root);
}
