#include <stdio.h>
#define size 5

void arrayLQ()
{
    int queue[size], ch = 1, j = 1, i;
    int rear = 0, front = 0;

    while (ch)
    {
        printf("\n1.Insertion \n2.Display \n3.Exit");
        printf("\n\nEnter your choice:");
        scanf("%d", &ch);
        switch (ch)
        {
        case 1:
            if (rear == size)
            {
                printf("\n\nQueue is Full...\n");
            }
            else
            {
                printf("\nEnter element for position [%d]:", j++);
                scanf("%d", &queue[rear++]);
            }
            break;
        case 2:
            if (front == rear)
            {
                printf("\n\nQueue is Empty...\n");
            }
            else
            {
                for (i = front; i < rear; i++)
                {
                    printf("\nElement at position [%d] is : %d \n", i, queue[i]);
                }
            }
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
    arrayLQ();
    return 0;
}