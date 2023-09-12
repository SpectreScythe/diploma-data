#include <stdio.h>

struct yoLL
{
    int data;
    struct yoLL *next;
} *start = NULL;

void insertLL()
{
    int noOfNodes = 0;
    int nodeData;

    struct yoLL *newNode;
    struct yoLL *last = start;

    newNode = malloc(sizeof(struct yoLL));
    printf("Enter data for element[%d]:", ++noOfNodes);
    scanf("%d", &nodeData);

    newNode->data = nodeData;
    newNode->next = NULL;

    if (start == NULL)
    {
        start = newNode;
        return;
    }
    else
    {
        while (last->next != NULL)
        {
            last = last->next;
        }

        last->next = newNode;
    }
}

void traverseLL()
{
    int traverseNodeCount = 0;
    struct yoLL *displayinNodes = start;

    if (displayinNodes == NULL)
    {
        printf("Link List is EMPTY...");
    }

    else
    {
        printf("\n");
        while (displayinNodes != NULL)
        {
            printf("Node [%d] Data -> %d\n", ++traverseNodeCount, displayinNodes->data);
            displayinNodes = displayinNodes->next;
        }
    }
}

void masterFunction()
{
    int ch = 1;
    while (ch)
    {
        printf("\n1.Insertion \n2.Display \n3.Exit");
        printf("\n\nEnter your choice:");
        scanf("%d", &ch);
        switch (ch)
        {
        case 1:
            insertLL();
            break;
        case 2:
            traverseLL();
            break;
        case 3:
            exit(0);
        default:
            printf("\n\nWrong Choice: please see the options");
        }
    }
}

int main()
{
    masterFunction();
    return 0;
}