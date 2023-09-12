#include<stdio.h>
void sort_array(){
    int element[10],i,j,temp;
   printf("Enter 10 integer numbers:");
   for(i=0;i<10;i++){
      scanf("%d",&element[i]);
   }
   for(i=0;i<10-1;i++){
      for(j=i+1;j<10;j++){
         if(element[i]>element[j]){
            temp=element[i];
            element[i]=element[j];
            element[j]=temp;
         }
      }
   }
   printf("Elements are now in ascending order:");
   for(i=0;i<10;i++)
      printf("%d\n",element[i]);
}
int main(){
   sort_array();
   return 0;
}