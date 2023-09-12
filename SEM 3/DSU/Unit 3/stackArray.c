#include <stdio.h>

#define size 10
int top = -1;
int stack_array[size];

void popStackArray()
{
    if (top == -1)
    {
        printf("\n\t Stack underflow!!!\n");
    }
    else
    {
        printf("\n\t Element %d - Popped from stack\n", stack_array[top]);
        top = top - 1;
    }
}

void pushStackArray()
{
    int stackData;
    if (top == size)
    {
        printf("\n\t Stack overflow!!!\n");
    }
    else
    {
        printf("\n\t Enter data to be pushed:");
        scanf("%d", &stackData);
        top = top + 1;
        stack_array[top] = stackData;
        printf("\n\t Element %d - Pushed into stack\n", stack_array[top]);
    }
}

void displayStackArray()
{
    if (top == -1)
    {
        printf("\n\t Stack underflow!!!\n");
    }
    else
    {
        printf("\n\t");
        printf("NULL");
        for (int i = top; i >= 0; i--)
        {
            printf("<----%d", stack_array[i]);
        }
        printf("\n");
    }
}

void stackArray()
{
    int choice;

    printf("\n\tFollowing operations on stack can occur according to their respective number:\n");

    while (1)
    {
        printf("\n\t 1 - Popping from the stack");
        printf("\n\t 2 - Pushing in to the stack");
        printf("\n\t 3 - Display the created stack");
        printf("\n\t 4 - Exit");

        printf("\n\n\t Enter your choice:");

        scanf("%d", &choice);

        switch (choice)
        {
        case 1:
            popStackArray();
            break;
        case 2:
            pushStackArray();
            break;
        case 3:
            displayStackArray();
            break;
        case 4:
            exit(0);
        default:
            printf("\n\t Invalid Choice!!!\n");
        }
    }
}

int main()
{
    stackArray();
    return 0;
}