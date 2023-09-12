#include <stdio.h>

#define MAX 5
int cqueue_arr[MAX];
int front = -1;
int rear = -1;

void insert(int item){
    if ((front == 0 && rear == MAX - 1) || (front == rear + 1))
    {
        printf("\n\n\t\tQueue Overflow n");
        return;
    }
    if (front == -1)
    {
        front = 0;
        rear = 0;
    }
    else
    {
        if (rear == MAX - 1)
            rear = 0;
        else
            rear = rear + 1;
    }
    cqueue_arr[rear] = item;
}

void deletion(){
    if (front == -1)
    {
        printf("\n\n\t\tQueue Underflown");
        return;
    }
    printf("\n\n\t\tElement deleted from queue is : %dn", cqueue_arr[front]);
    if (front == rear)
    {
        front = -1;
        rear = -1;
    }
    else
    {
        if (front == MAX - 1)
            front = 0;
        else
            front = front + 1;
    }
}

void display(){
    int front_pos = front, rear_pos = rear;
    if (front == -1)
    {
        printf("\n\n\t\tQueue is emptyn");
        return;
    }
    printf("\n\n\t\tQueue elements :n");
    if (front_pos <= rear_pos)
        while (front_pos <= rear_pos)
        {
            printf("%d ", cqueue_arr[front_pos]);
            front_pos++;
        }
    else
    {
        while (front_pos <= MAX - 1)
        {
            printf("%d ", cqueue_arr[front_pos]);
            front_pos++;
        }
        front_pos = 0;
        while (front_pos <= rear_pos)
        {
            printf("%d ", cqueue_arr[front_pos]);
            front_pos++;
        }
    }
    printf("n");
}

int main(){
    system("color a");

    int choice, item;
    do
    {
        printf("\n\n\t\t1.Insertn");
        printf("\n\t\t2.Deleten");
        printf("\n\t\t3.Displayn");
        printf("\n\t\t4.Quitn");
        printf("\n\t\tEnter your choice : ");
        scanf("%d", &choice);
        switch (choice)
        {
        case 1:
            printf("\n\t\tInput the element for insertion in queue : ");
            scanf("%d", &item);
            insert(item);
            break;
        case 2:
            deletion();
            break;
        case 3:
            display();
            break;
        case 4:
            break;
        default:
            printf("\n\t\tWrong choicen");
        }
    } while (choice != 4);
    return 0;
}