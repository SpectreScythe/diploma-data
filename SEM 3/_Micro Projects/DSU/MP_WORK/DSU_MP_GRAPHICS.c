
//--------------------------------------------------------------------------------------------------------------------------------------------------//

// DSU Micro - Project

//--------------------------------------------------------------------------------------------------------------------------------------------------//

// Header Files

//-------------------------------------------------------------------------//

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <dos.h>
#include <graphics.h>

//-------------------------------------------------------------------------//

// User Interface --- Funtions

//-------------------------------------------------------------------------//

void homeScreen();
void screenBorder();
void uiCreate();
void loadingCreate();
void uiDelete();
void loadingDelete();
void uiDeposit();
void loadingDeposit();
void uiWithdraw();
void loadingWithdraw();
void uiViewing();
void loadingViewing();
void displayView();
void mainMenuButtons();

int i;
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Tree Structure

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

typedef struct node
{
  int accno;
  int balance;
  char name[30];
  struct node *left, *right;
} node;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// New Noden Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *newNode(char *name, int accno)
{
  node *temp = (node *)malloc(sizeof(struct node));
  strcpy(temp->name, name);
  temp->balance = 500;
  temp->accno = accno;
  temp->left = temp->right = NULL;
  return temp;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Findin Smallestn Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *smallestBankAccNum(struct node *root)
{
  struct node *current = root;

  while (current && current->left != NULL)
    current = current->left;

  return current;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Deletin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *deleteACC(struct node *root, int accno)
{
  if (root == NULL)
    return root;

  if (accno < root->accno)
    root->left = deleteACC(root->left, accno);

  else if (accno > root->accno)
    root->right = deleteACC(root->right, accno);

  else
  {
    if (root->left == NULL)
    {
      struct node *temp = root->right;
      free(root);
      return temp;
    }
    else if (root->right == NULL)
    {
      struct node *temp = root->left;
      free(root);
      return temp;
    }

    struct node *temp = smallestBankAccNum(root->right);

    root->accno = temp->accno;

    root->right = deleteACC(root->right, temp->accno);
  }
  return root;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Insertin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *insert(struct node *root, char *name, int accno)
{

  if (root == NULL)
    return newNode(name, accno);

  if (accno < root->accno && accno != root->accno)
    root->left = insert(root->left, name, accno);
  else
    root->right = insert(root->right, name, accno);

  return root;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// In-Orderin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void inorder(struct node *root)
{
  if (root != NULL)
  {
    inorder(root->left);
    printf("\t\t\t\t\t\tAccount Holder = %s\n", root->name);
    printf("\t\t\t\t\t\tAccount Number = %d\n", root->accno);
    printf("\t\t\t\t\t\tAccount Balance = $%d\n", root->balance);
    inorder(root->right);
  }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Post-Orderin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void preorder(struct node *root)
{
  if (root != NULL)
  {
    printf("\t\t\t\t\t\tAccount Holder = %s\n", root->name);
    printf("\t\t\t\t\t\tAccount Number = %d\n", root->accno);
    printf("\t\t\t\t\t\tAccount Balance = $%d\n", root->balance);
    preorder(root->left);
    preorder(root->right);
  }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Pre-Orderin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void postorder(struct node *root)
{
  if (root != NULL)
  {
    postorder(root->left);
    postorder(root->right);
    printf("\t\t\t\t\t\tAccount Holder = %s\n", root->name);
    printf("\t\t\t\t\t\tAccount Number = %d\n", root->accno);
    printf("\t\t\t\t\t\tAccount Balance = $%d\n", root->balance);
  }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Depostin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *deposit(node *root, int acc, int amt)
{
  node *temp;
  temp = root;
  if (temp == NULL)
  {
    printf("\n\t\t\t\t\t\tYou Haven't Created an account yet...\ntry creating an account\n\n");
    return NULL;
  }
  if (acc == temp->accno)
  {
    temp->balance += amt;
    return root;
  }
  else if (temp->accno > acc)
  {
    return deposit(root->left, acc, amt);
  }
  else
  {
    return deposit(root->right, acc, amt);
  }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Withdrawin Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

struct node *withdraw(node *root, int acc, int amt)
{
  node *temp;
  temp = root;
  if (temp == NULL)
  {
    printf("\n\t\t\t\t\t\tYou Haven't Created an account yet...\ntry creating an account\n\n");
    return NULL;
  }
  if (acc == temp->accno)
  {
    if (acc <= 500)
    {
      printf("\n\t\t\t\t\t\tOperation Denied:Minimum Deposit amount should be $500");
      return 0;
    }
    else
    {
      temp->balance -= amt;
      return root;
    }
  }
  else if (temp->accno > acc)
  {
    return deposit(root->left, acc, amt);
  }
  else
  {
    return deposit(root->right, acc, amt);
  }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Menu Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

int menu()
{
  int chc;
  printf("\n\n------------------------------------------>   BANKING MANAGEMENT SYSTEM   <-----------------------------------------------");

  printf("\n\n\n-----------------------------------------[   WELCOME TO Omega Trust CORPS   ]---------------------------------------------\n\n\n");

  printf("\t\t\t\t\t\t1.Create an Account\n\t\t\t\t\t\t2.Delete an Account\n\t\t\t\t\t\t3.Deposit\n\t\t\t\t\t\t4.Withdrawal\n\t\t\t\t\t\t5.View Account\n\t\t\t\t\t\t6.Exit\n");

  printf("\n\n\t\t\t\t\t\tChoose An action = ");
  scanf("%d", &chc);

  return (chc);
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

// Project Function

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

void DSU_PROJECT()
{
  system("color a");
  system("font 32");

  node *root = NULL;
  int n, accno, del, chk, acc, acn, amt, amt2;
  char name[30];

A:

  n = menu();

  switch (n)

  {

  case 1:
    printf("\n\t\t\t\t\t\tEnter Your Name = ");
    scanf("%s", name);
    printf("\t\t\t\t\t\tEnter Account Number = ");
    scanf("%d", &accno);
    root = insert(root, name, accno);
    printf("\n\t\t\t\t\t<<<<Account Created Successfully>>>>\n");
    goto A;

  case 2:

    printf("\t\t\t\t\t\tEnter Account No = ");
    scanf("%d", &del);
    root = deleteACC(root, del);
    printf("\n\t\t\t\t\t<<<<Account Deleted Successfully>>>>\n");
    goto A;

  case 3:

    printf("\t\t\t\t\t\tEnter the Account Number = ");
    scanf("%d", &acc);
    printf("\t\t\t\t\t\tEnter the Amount to Deposit = ");
    scanf("%d", &amt);
    root = deposit(root, acc, amt);
    if (root != NULL)
    {
      printf("\t\t\t\t\t\tAccount holder = %s", root->name);
      printf("\n\t\t\t\t\t\tAccount Number = %d", root->accno);
      printf("\n\t\t\t\t\t\tAccount Balance = $%d", root->balance);
    }
    goto A;

  case 4:

    printf("\t\t\t\t\t\tEnter Account Number = ");
    scanf("%d", &acn);
    printf("\t\t\t\t\t\tEnter the Amount to Withdraw =$");
    scanf("%d", &amt2);
    root = withdraw(root, acn, amt2);
    if (root != NULL)
    {
      printf("\t\t\t\t\t\tAccount holder = %s", root->name);
      printf("\n\t\t\t\t\t\tAccount Number = %d", root->accno);
      printf("\n\t\t\t\t\t\tAccount Balance = $%d", root->balance);
    }
    goto A;

  case 5:

    printf("\n\t\t\t\t\t\t1.In-order\n\t\t\t\t\t\t2.Pre-order\n\t\t\t\t\t\t3.Post-order\n");
    printf("\t\t\t\t\t\tChoose an Action = ");
    scanf("%d", &chk);
    if (chk == 1)
    {
      printf("\n\t\t\t\t\tAccounts are Arranged in (in-order)\n ");
      printf("\t\t\t\t\t----------------------------------");
      printf("\n\t\t\t\t\t<<<<Account Details>>>>\n\n");
      inorder(root);
    }
    else if (chk == 2)
    {
      printf("\n\t\t\t\t\tAccounts are Arranged in (Pre-order)\n ");
      printf("\t\t\t\t\t----------------------------------");
      printf("\n\t\t\t\t\t<<<<Account Details>>>>\n\n");
      preorder(root);
    }
    else
    {
      printf("\n\t\t\t\t\tAccounts are Arranged in (Post-order)\n ");
      printf("\t\t\t\t\t----------------------------------");
      printf("\n\t\t\t\t\t<<<<Account Details>>>>\n\n");
      postorder(root);
    }
    goto A;

  case 6:

    return 0;
  default:

    printf("\t\t\t\t\t\tInvalid Choice!!");
    goto A;
  }
  getch();
}

//-------------------------------------------------------------------------//

// Main Function

//-------------------------------------------------------------------------//

int main()
{
  int gd = DETECT, gm;
  initgraph(&gd, &gm, " ");

  // for (i = 0; i < 100; i++)
  // {
  homeScreen();
  // delay(5);
  // }

  settextstyle(0, 0, 1);

  outtextxy(380, 390, "Press any key to continue...");
  getch();
  cleardevice();

  // Horizontal Border

  line(0, 196, 640, 196);
  line(0, 197, 640, 197);
  line(0, 198, 640, 198);
  line(0, 199, 640, 199);
  line(0, 200, 640, 200);
  line(0, 201, 640, 201);
  line(0, 202, 640, 202);
  line(0, 203, 640, 203);
  line(0, 204, 640, 204);

  cleardevice();

  menu();
  return 0;
}

//-------------------------------------------------------------------------//

// Home Screem Function

//-------------------------------------------------------------------------//

void homeScreen()
{

  setcolor(2);

  // screenBorder();

  settextstyle(0, 0, 4);
  outtextxy(80, 70, "Data Structures"); // Title
  outtextxy(130, 130, "Using C");       // Title
  outtextxy(80, 190, "Micro-Project");  // Title

  // Horizontal Border

  line(0, 250, 640, 250);
  line(0, 251, 640, 251);
  line(0, 252, 640, 252);
  line(0, 253, 640, 253);
  line(0, 254, 640, 254);
  line(0, 255, 640, 255);
  line(0, 256, 640, 256);
  line(0, 257, 640, 257);
  line(0, 258, 640, 258);
  line(0, 259, 640, 259);

  settextstyle(0, 0, 2);
  outtextxy(120, 290, "Guided By Ms. Shafaque"); // Faculty

  settextstyle(0, 0, 1);
  outtextxy(120, 320, "210451---Abdurrahman Qureshi"); // Participants Roll No
  outtextxy(120, 340, "210454---Azlan Shaikh");        // Participants Roll No
  outtextxy(120, 360, "210459---Owais Khan");          // Participants Roll No
  outtextxy(120, 400, "210481---Faisal Ansari");       // Participants Roll No
  outtextxy(120, 380, "210482---Chirag Gothankar");    // Participants Roll No

  getch();

  clrscr();
  cleardevice();

  settextstyle(0, 0, 4);

  outtextxy(200, 50, "Banking");
  outtextxy(200, 120, "System");

  outtextxy(120, 260, "Via Binary");
  outtextxy(120, 300, "Search Tree");
}

//-------------------------------------------------------------------------------//

// Border Function

//-------------------------------------------------------------------------------//

void screenBorder()
{
  cleardevice();

  setcolor(2);

  // Top Border

  line(0, 0, 640, 0);
  line(0, 2, 640, 2);
  line(0, 3, 640, 3);
  line(0, 4, 640, 4);
  line(0, 5, 640, 5);
  line(0, 6, 640, 6);
  line(0, 7, 640, 7);
  line(0, 8, 640, 8);
  line(0, 9, 640, 9);
  line(0, 1, 640, 1);

  // Bottom Border

  line(0, 471, 640, 471);
  line(0, 472, 640, 472);
  line(0, 473, 640, 473);
  line(0, 474, 640, 474);
  line(0, 475, 640, 475);
  line(0, 476, 640, 476);
  line(0, 477, 640, 477);
  line(0, 478, 640, 478);
  line(0, 479, 640, 479);
  line(0, 480, 640, 480);

  // Left Border

  line(0, 0, 0, 480);
  line(1, 0, 1, 480);
  line(2, 0, 2, 480);
  line(3, 0, 3, 480);
  line(4, 0, 4, 480);
  line(5, 0, 5, 480);
  line(6, 0, 6, 480);
  line(7, 0, 7, 480);
  line(8, 0, 8, 480);
  line(9, 0, 9, 480);

  // Right Border

  line(631, 0, 631, 480);
  line(632, 0, 632, 480);
  line(633, 0, 633, 480);
  line(634, 0, 634, 480);
  line(635, 0, 635, 480);
  line(636, 0, 636, 480);
  line(637, 0, 637, 480);
  line(638, 0, 638, 480);
  line(639, 0, 639, 480);
  line(640, 0, 640, 480);

  mainMenuButtons();
}

//-------------------------------------------------------------------------------//

// Main Menu Functions

//-------------------------------------------------------------------------------//

void mainMenuButtons()
{
  setcolor(10);
  line(0, 80, 640, 80);

  settextstyle(0, 0, 4);
  outtextxy(85, 30, "INDIAN BANK");

  settextstyle(0, 0, 2);
  outtextxy(80, 100, "Press the corresponding number");
  outtextxy(80, 130, "for the corresponding function:");

  setcolor(14);

  settextstyle(0, 0, 2);

  rectangle(50, 160, 300, 240);
  outtextxy(60, 180, "1: Create");
  outtextxy(60, 210, "   an account");

  rectangle(50, 260, 300, 340);
  outtextxy(60, 280, "2: Delete");
  outtextxy(60, 310, "   an account");

  rectangle(50, 360, 300, 440);
  outtextxy(60, 380, "3: Deposit");
  outtextxy(60, 410, "   in account");

  rectangle(320, 160, 580, 240);
  outtextxy(330, 180, "4: Withdrawl");
  outtextxy(330, 210, "   from account");

  rectangle(320, 260, 580, 340);
  outtextxy(330, 280, "5: View account");

  rectangle(320, 360, 580, 440);
  outtextxy(330, 380, "6: Exit");
}

//-------------------------------------------------------------------------------//

// UI  --- Create

//-------------------------------------------------------------------------------//

void uiCreate()
{
  cleardevice();

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 60, "---Account Creation---");

  outtextxy(100, 200, "Enter your name:");

  outtextxy(100, 300, "Enter your account number:");
}

//-------------------------------------------------------------------------------//

// Loading  --- Create

//-------------------------------------------------------------------------------//

void loadingCreate()
{

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 40, "Creating your account...");

  // Outer Circle

  ellipse(310, 250, 90 + i, 100 + i, 70, 70); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 69, 69); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 68, 68); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 67, 67); // Loading Arcs

  // Inner Circle

  ellipse(310, 250, 90 - i, 100 - i, 30, 30); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 29, 29); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 28, 28); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 27, 27); // Loading Arcs
}

//-------------------------------------------------------------------------------//

// UI  --- Delete

//-------------------------------------------------------------------------------//

void uiDelete()
{
  cleardevice();

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 60, "---Account Deletion---");

  outtextxy(100, 200, "Enter your account number:");
}

//-------------------------------------------------------------------------------//

// Loading  --- Delete

//-------------------------------------------------------------------------------//

void loadingDelete()
{

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 40, "Deletin your account...");

  // outtextxy(100, 300, "Enter your account number:");

  // Outer Circle

  ellipse(310, 250, 90 + i, 100 + i, 70, 70); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 69, 69); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 68, 68); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 67, 67); // Loading Arcs

  // Inner Circle

  ellipse(310, 250, 90 - i, 100 - i, 30, 30); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 29, 29); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 28, 28); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 27, 27); // Loading Arcs
}

//-------------------------------------------------------------------------------//

// UI --- Deposit

//-------------------------------------------------------------------------------//

void uiDeposit()
{
  cleardevice();

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 60, "---Account Deposition---");

  outtextxy(100, 200, "Enter your account number:");

  outtextxy(100, 300, "Enter deposit amount:");
}

//-------------------------------------------------------------------------------//

// Loading  --- Deposit

//-------------------------------------------------------------------------------//

void loadingDeposit()
{

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(20, 40, "Depositng into your account...");

  // Outer Circle

  ellipse(310, 250, 90 + i, 100 + i, 70, 70); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 69, 69); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 68, 68); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 67, 67); // Loading Arcs

  // Inner Circle

  ellipse(310, 250, 90 - i, 100 - i, 30, 30); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 29, 29); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 28, 28); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 27, 27); // Loading Arcs
}

//-------------------------------------------------------------------------------//

// UI --- Withdrawl

//-------------------------------------------------------------------------------//

void uiWithdraw()
{
  cleardevice();

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 60, "---Account Withdrawl---");

  outtextxy(100, 200, "Enter your account number:");

  outtextxy(100, 300, "Enter withdrawl amount:");
}

//-------------------------------------------------------------------------------//

// Loading  --- Withdrawl

//-------------------------------------------------------------------------------//

void loadingWithdraw()
{

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(20, 40, "Withdrawling from your account...");

  // Outer Circle

  ellipse(310, 250, 90 + i, 100 + i, 70, 70); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 69, 69); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 68, 68); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 67, 67); // Loading Arcs

  // Inner Circle

  ellipse(310, 250, 90 - i, 100 - i, 30, 30); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 29, 29); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 28, 28); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 27, 27); // Loading Arcs
}

//-------------------------------------------------------------------------------//

// UI  --- Viewing

//-------------------------------------------------------------------------------//

void uiViewing()
{
  cleardevice();

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 60, "---Account Display---");

  outtextxy(100, 200, "1.In-order");

  outtextxy(100, 230, "2.Pre-order");

  outtextxy(100, 260, "3.Post-order");
}

//-------------------------------------------------------------------------------//

// Loading  --- Viewing

//-------------------------------------------------------------------------------//

void loadingViewing()
{

  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  outtextxy(100, 40, "Fetching accounts...");

  // Outer Circle

  ellipse(310, 250, 90 + i, 100 + i, 70, 70); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 69, 69); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 68, 68); // Loading Arcs

  ellipse(310, 250, 90 + i, 100 + i, 67, 67); // Loading Arcs

  // Inner Circle

  ellipse(310, 250, 90 - i, 100 - i, 30, 30); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 29, 29); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 28, 28); // Loading Arcs

  ellipse(310, 250, 90 - i, 100 - i, 27, 27); // Loading Arcs
}

//-------------------------------------------------------------------------------//

// Viewing Details

//-------------------------------------------------------------------------------//

void displayView()
{
  line(0, 100, 640, 100);
  line(0, 101, 640, 101);
  line(0, 102, 640, 102);
  line(0, 103, 640, 103);
  line(0, 104, 640, 104);

  settextstyle(0, 0, 2);
  outtextxy(100, 40, "---Account Details---");
}

//--------------------------------------------------------------------------------------------------------------------------------------------------//

// End OF Program

//--------------------------------------------------------------------------------------------------------------------------------------------------//