#include<stdio.h>
#include<stdlib.h>

struct node{
   int data;
   struct node *next; 
};

struct node* top = NULL;

int popStackLinkList(){

    struct node *poppinNode = top;
    
    if(top == NULL){
        printf("\n\n\t Stack underflow!!!\n");
    }
    else{
        int temp_data = top->data;
        top = top->next;
        printf("\n\n\t Number %d popped into the stack",poppinNode);    
        free(poppinNode);
        return temp_data;
    }
}

void pushStackLinkList(){
    
    int num;
    struct node *pushNewNode;
    pushNewNode = (struct node*)malloc(sizeof(pushNewNode));

    printf("\n\n\t Enter a number to push into the stack:");
    scanf("%d",&num);
    if(top == NULL){
        pushNewNode->next = NULL;
    }
    else{
        pushNewNode->data = num;
        pushNewNode->next = top;
    }
    top = pushNewNode;
    printf("\n\n\t Number %d pushed into the stack",num);
}

void displayStackLinkList(){
    
    struct node *temp = top;
    
    if (top == NULL) {
        printf("\n\t Stack Underflow!!!");
        return;
    }
    else{
        printf("\n\t The stack is as follows:\n");
        printf("\t");
        printf("\n\t NULL ");
        while(temp != NULL){
            printf("%d---->",temp->data);
            temp=temp->next;
        }
        //printf("%d---->NULL",temp->data);
    } 
}

// void displayStackLinkList(){
//     if (top == NULL) {
//         printf("\n\t Stack Underflow!!!");
//     }
//     else{
//         printf("\n\t The stack is as follows:\n");

//         //printf("\t");
//         struct node *temp;
//         temp = top;
//         while(temp->next != NULL){
//             printf("%d---->",temp->data);
//             temp=temp->next;
//         }
//         printf("%d---->NULL",temp->data);
//     }
// }

void stackLinkList(){
    int choice;

        printf("\n\tFollowing operations on stack can occur according to their respective number:\n");

    while(1){
        printf("\n\t 1 - Popping from the stack");
        printf("\n\t 2 - Pushing in to the stack");
        printf("\n\t 3 - Display the created stack");
        printf("\n\t 4 - Exit \n");

        printf("\n\t Enter your choice:");

        scanf("%d",&choice);

        switch(choice){
            case 1:
                popStackLinkList();
                break;
            case 2:
                pushStackLinkList();
                break;
            case 3:
                displayStackLinkList();
                break;
            case 4:
                exit(0);
            default :
                printf("\n\t Invalid Choice!!!\n");
        }
    }
}

int main(){
    stackLinkList();
    return 0;
}