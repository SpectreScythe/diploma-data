#include <stdio.h>
#include <stdlib.h>
struct node
{
    int info;
    struct node *ptr;
} * front, *rear, *temp, *front1;
int frontelement();
void enq(int data);
void deq();
void display();
void create();
int count = 0;
int main()
{
    int no, ch, e;
   printf("1 - Enqueue");
   printf(" 2 - Dequeue");
   printf("3 - Display");
   printf("4 - Exit");
   printf("5-front");
   create();
   while (1){
      printf("Enter choice : ");
      scanf("%d", &ch);
      switch (ch){
        case 1:
            printf("Enter data : ");
            scanf("%d", &no);
            enq(no);
            break;
        case 2:
            deq();
            break;
        case 3:
            display();
            break;
        case 4:
            exit(0);
            break;
        case 5:
            e = frontelement();
            if (e != 0)
                printf("Front element : %d", e);
            else
            printf("No front element in Queue");
         break;
         default:
         printf("Wrong choice, Try again ");
         break;
      }
   }
   return 0;
}
void enq(int data)
{
    if (rear == NULL)
    {
        rear = (struct node *)malloc(1 * sizeof(struct node));
        rear->ptr = NULL;
        rear->info = data;
        front = rear;
    }
    else
    {
        temp = (struct node *)malloc(1 * sizeof(struct node));
        rear->ptr = temp;
        temp->info = data;
        temp->ptr = NULL;
        rear = temp;
    }
    count++;
}
void display()
{
    front1 = front;
    if ((front1 == NULL) && (rear == NULL))
    {
        printf("Queue is empty");
        return;
    }
    while (front1 != rear)
    {
        printf("%d ", front1->info);
        front1 = front1->ptr;
    }
    if (front1 == rear)
        printf("%d", front1->info);
}
void deq()
{
    front1 = front;
    if (front1 == NULL)
    {
         printf("Error");
         return;
    }
    else if (front1->ptr != NULL)
    {
        front1 = front1->ptr;
         printf("Dequeued value : %d", front->info);
         free(front);
         front = front1;
    }
    else
    {
         printf(" Dequeued value : %d", front->info);
         free(front);
         front = NULL;
      rear = NULL;
    }
    count--;
}
int frontelement()
{
    if ((front != NULL) && (rear != NULL))
        return (front->info);
    else
        return 0;
}