#include <stdio.h>
#include <stdlib.h>

int n, i;

struct node
{
    int value;
    struct node *next;
} * LL;

void listData()
{
    printf("Enter no of node:");
    scanf("%d", &n);
    createLinkList(n);
    printf("Data in Link list:");
    displayLinkList();
}

void createLinkList()
{
    struct node *temp, *start;
    int data;
    LL = (struct node *)malloc(sizeof(LL));
    if (LL == NULL)
    {
        printf("No memory!!!");
    }
    else
    {
        printf("Enter value of Node 1:");
        scanf("%d", &data);
        LL = (struct node *)malloc(sizeof(LL));
        LL->value = data;
        LL->next = NULL;
        temp = LL;
        for (i = 2; i <= n; i++)
        {
            start = (struct node *)malloc(sizeof(start));
            if (start == NULL)
            {
                printf("No memory!!!");
                break;
            }
            else
            {
                printf(" Input data for node %d : ", i);
                scanf(" %d", &data);
                start->value = data;
                start->next = NULL;
                temp->next = start;
                temp = temp->next;
            }
        }
    }
}

void displayLinkList()
{
    struct node *temp;
    if (LL == NULL)
    {
        printf("No memory!!!");
    }
    else
    {
        temp = LL;
        printf(" Link List => %d ", temp->value);
        temp = temp->next;
        while (temp != NULL)
        {
            printf(" , %d", temp->value);
            temp = temp->next;
        }
    }
}

int main()
{
    return 0;
}