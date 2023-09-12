#include <bits/stdc++.h>
using namespace std;
struct Node {
   int data;
   struct Node* next;
};
void printLargestSmallestLinkedList(struct Node* head) {
   int maxElement = INT_MIN;
   int minElement = INT_MAX;
   while (head != NULL) {
      if (minElement > head->data)
         minElement = head->data;
      if (maxElement < head->data)
         maxElement = head->data;
      head = head->next;
   }
   cout<<"Smallest element in the linked list is : "<<minElement<<endl;
   cout<<"Largest element in the linked list is : "<<maxElement<<endl;
}
void push(struct Node** head, int data) {
   struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
   newNode->data = data;
   newNode->next = (*head);
   (*head) = newNode;
}
int main() {
   struct Node* head = NULL;
   push(&head, 5);
   push(&head, 2);
   push(&head, 7);
   push(&head, 3);
   push(&head, 9);
   push(&head, 1);
   push(&head, 4);
   printLargestSmallestLinkedList(head);
   return 0;
}
