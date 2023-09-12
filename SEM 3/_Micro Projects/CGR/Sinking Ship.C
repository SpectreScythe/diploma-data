
/*-------------------------------------------------------------------------------*/

// Computer Graphics Micro-Project

/*-------------------------------------------------------------------------------*/

// Header Files

/*-------------------------------------------------------------------------------*/

#include <stdio.h>
#include <conio.h>
#include <dos.h>
#include <graphics.h>

/*-------------------------------------------------------------------------------*/

// GLOBAL DECLARATIONS

int i, x = 0, y = 300, flag;
// int newcolor = 12;
// // new color which you want to fill
// int oldcolor = 0; // Global Variables

/*-------------------------------------------------------------------------------*/

// 210454

/*-------------------------------------------------------------------------------*/

// void bfa(int x, int y, int ncolor, int dcolor);
void shipwreck(int x, int y);
void ship(int i);
void stars();
void wave();

/*-------------------------------------------------------------------------------*/

// 210451

/*-------------------------------------------------------------------------------*/

void boom();
void bigBoom();
void PROJECT();
void homeScreen();
void meteor(int i);
void screenBorder();
void loadingScreen();

/*-------------------------------------------------------------------------------*/

// Main Function

/*-------------------------------------------------------------------------------*/

int main()
{
	int gd = DETECT, gm;
	initgraph(&gd, &gm, " ");

	PROJECT();

	getch();

	closegraph();

	return 0;
}

/*-------------------------------------------------------------------------------*/

// Project Function	---	210451

/*-------------------------------------------------------------------------------*/

void PROJECT()
{

	int choice;

	setcolor(12);

	screenBorder();

	for (i = 0; i < 100; i++)
	{
		homeScreen();
		delay(5);
	}

	settextstyle(0, 0, 1);
	outtextxy(380, 390, "Press any key to continue...");
	getch();

	cleardevice();

	screenBorder();

	// Title Part

	settextstyle(0, 0, 6);

	outtextxy(130, 50, "SINKING");

	outtextxy(200, 120, "SHIP");

	//Horizontal Border

	line(0, 196, 640, 196);
	line(0, 197, 640, 197);
	line(0, 198, 640, 198);
	line(0, 199, 640, 199);
	line(0, 200, 640, 200);
	line(0, 201, 640, 201);
	line(0, 202, 640, 202);
	line(0, 203, 640, 203);
	line(0, 204, 640, 204);

	// ChoicePart

	settextstyle(0, 0, 2);

	outtextxy(30, 230, "Choose one of the following options:");

	outtextxy(150, 260, "Press 1 to START");

	outtextxy(150, 290, "Press 2 to EXIT");

	// Right Button

	rectangle(50, 350, 250, 450);

	settextstyle(0, 0, 4);

	outtextxy(75, 385, "START");

	// Left Button

	rectangle(350, 350, 550, 450);

	settextstyle(0, 0, 4);

	outtextxy(390, 385, "EXIT");

	scanf("%d", &choice);

	while (1)
	{
		switch (choice)
		{
		case 1:

			cleardevice();

			screenBorder();

			for (i = 0; i < 360; i++)
			{

				loadingScreen();
				delay(8);
			}

			settextstyle(0, 0, 1);
			outtextxy(380, 412, "Press any key to continue...");
			getch();

			// BEFORE COLLISION

			for (i = 0; i < 280; i++)
			{
				ship(i);
				stars();
				meteor(i);
				wave();
				delay(10);
				cleardevice();
			}

			// AFTER COLLISION

			for (i = 0; i < 50; i++)
			{
				bigBoom();
				boom(350, 250 - i);
				shipwreck(280, 300 + i);
				stars();
				wave();
				delay(10);
				cleardevice();
			}

		case 2:
			exit(0);

		default:
			printf("\n\t Invalid Choice!!!\n");
		}
	}
	// ship(i);
}

// flood fill algorithm
void flood(int x, int y, int new_col, int old_col)
{
    // check current pixel is old_color or not
    if (getpixel(x, y) == old_col) {
 
        // put new pixel with new color
        putpixel(x, y, new_col);
 
        // recursive call for bottom pixel fill
        flood(x + 1, y, new_col, old_col);
 
        // recursive call for top pixel fill
        flood(x - 1, y, new_col, old_col);
 
        // recursive call for right pixel fill
        flood(x, y + 1, new_col, old_col);
 
        // recursive call for left pixel fill
        flood(x, y - 1, new_col, old_col);
    }
}

/*-------------------------------------------------------------------------------*/

// Ship Function	---	210454

/*-------------------------------------------------------------------------------*/

void ship(int i)
{
	line(x + i, y, x + 45 + i, y + 50);
	line(x + i, y, x + 150 + i, y);

	line(x + 45 + i, y + 50, x + 250 + i, y + 50);
	line(x + 27 + i, y + 30, x + 263 + i, y + 30);

	//	bfa(x + 55, y + 40, RED);

	line(x + 250 + i, y + 50, x + 300 + i, y - 22);

	line(x + 300 + i, y - 22, x + 200 + i, y - 22);
	line(x + 200 + i, y - 22, x + 150 + i, y);

	line(x + 20 + i, y, x + 20 + i, y - 80);
	line(x + 50 + i, y, x + 50 + i, y - 80);

	line(x + 20 + i, y - 80, x + 50 + i, y - 80);
	line(x + 20 + i, y - 50, x + 50 + i, y - 50);

	line(x + 20 + i, y - 30, x + 50 + i, y - 30);
	line(x + 80 + i, y, x + 80 + i, y - 100);

	line(x + 220 + i, y - 22, x + 80 + i, y - 100);

	circle(x + 120 + i, y - 33, 10);
}

/*-------------------------------------------------------------------------------*/

// Star Function	---	210454

/*-------------------------------------------------------------------------------*/

void stars()
{

	outtextxy(x + 10, y - 220, "*");
	outtextxy(x + 50, y - 210, "*");
	outtextxy(x + 40, y - 290, "*");
	outtextxy(x + 70, y - 270, "*");
	outtextxy(x + 120, y - 220, "*");

	outtextxy(x + 170, y - 370, "*");
	outtextxy(x + 130, y - 860, "*");
	outtextxy(x + 160, y - 330, "*");
	outtextxy(x + 140, y - 420, "*");
	outtextxy(x + 150, y - 223, "*");

	outtextxy(x + 180, y - 120, "*");
	outtextxy(x + 200, y - 432, "*");
	outtextxy(x + 630, y - 120, "*");
	outtextxy(x + 540, y - 520, "*");
	outtextxy(x + 600, y - 550, "*");

	outtextxy(x + 590, y - 470, "*");
	outtextxy(x + 440, y - 300, "*");
	outtextxy(x + 398, y - 100, "*");
	outtextxy(x + 555, y - 190, "*");
	outtextxy(x + 654, y - 10, "*");

	outtextxy(x + 444, y - 180, "*");
	outtextxy(x + 659, y - 233, "*");
	outtextxy(x + 564, y - 180, "*");
	outtextxy(x + 487, y - 120, "*");
	outtextxy(x + 630, y - 370, "*");

	setfillstyle(1, 15);

	pieslice(x + 220, y - 200, 0, 360, 35); // Moon
}

/*-------------------------------------------------------------------------------*/

// Ship Wreck Function	---	210454

/*-------------------------------------------------------------------------------*/

void shipwreck(int x, int y)
{

	line(x, y, x + 45, y + 50);
	line(x, y, x + 65, y);				   //
	line(x + 65, y, x + 100, y + 30);	   //
	line(x + 100, y + 30, x + 85, y + 50); //

	line(x + 45, y + 50, x + 85, y + 50);
	line(x + 130, y + 50, x + 250, y + 50);
	line(x + 250, y + 50, x + 300, y - 22);
	line(x + 300, y - 22, x + 200, y - 22);

	line(x + 200, y - 22, x + 150, y);		//
	line(x + 150, y, x + 120, y);			//
	line(x + 120, y, x + 150, y + 30);		//
	line(x + 150, y + 30, x + 130, y + 50); //

	line(x + 27, y + 30, x + 100, y + 30); //
	line(x + 150, y + 30, x + 263, y + 30);
	line(x + 20, y, x + 14, y - 30); // left
	line(x + 50, y, x + 43, y - 30); // right

	line(x + 14, y - 30, x + 43, y - 30);
	line(x + 132, y - 60, x + 130, y);
	// line(x+80,y,x+80,y-100);
	line(x + 220, y - 22, x + 132, y - 60);
}

/*-------------------------------------------------------------------------------*/

// Wave Function	---	210454

/*-------------------------------------------------------------------------------*/

void wave()
{

	line(0, y + 50, getmaxx(), y + 50); // wave
	setfillstyle(9, LIGHTBLUE);
	floodfill(x, y + 60, 15);
}

/*-------------------------------------------------------------------------------*/



/*-------------------------------------------------------------------------------*/

/*
void bfa(int x, int y, int ncolor){
 if(getpixel(x,y) != ncolor && getpixel(x,y) != WHITE){
  putpixel(x,y,ncolor);
  bfa(x+1,y,ncolor);
  bfa(x-1,y,ncolor);
  bfa(x,y+1,ncolor);
  bfa(x,y-1,ncolor);
 }
} */

/*-------------------------------------------------------------------------------*/

// Meteor Function	---	210451

/*-------------------------------------------------------------------------------*/

void meteor(int i)
{

	setcolor(YELLOW);
	setfillstyle(1, RED);

	circle(635 - i + 80, 0 + i - 80, 35); // Big

	circle(635 - i + 140, 0 + i - 120, 8); // Trail

	circle(635 - i + 130, 0 + i - 70, 10); // Trail

	circle(635 - i + 160, 0 + i - 90, 15); // Trail

	// Coloring the circles

	floodfill(635 - i + 160, 0 + i - 90, YELLOW);

	floodfill(635 - i + 130, 0 + i - 70, YELLOW);

	floodfill(635 - i + 140, 0 + i - 120, YELLOW);

	floodfill(635 - i + 80, 0 + i - 80, YELLOW);

	setcolor(WHITE);
}

/*-------------------------------------------------------------------------------*/

// Explosion Function	---	210451

/*-------------------------------------------------------------------------------*/

void bigBoom()
{

	setfillstyle(SOLID_FILL, WHITE);

	ellipse(350, 255, 0, 180, 30, 25); // Explosion Mushroom-Cloud

	ellipse(380, 280, 285, 90, 40, 30); // Explosion Mushroom-Cloud

	ellipse(365, 310, 210, 360, 25, 30); // Explosion Mushroom-Cloud

	ellipse(330, 300, 80, 300, 30, 30); // Explosion Mushroom-Cloud

	ellipse(320, 280, 85, 235, 30, 25); // Explosion Mushroom-Cloud

	floodfill(350, 280, WHITE);
}

/*-------------------------------------------------------------------------------*/

// Debris Function	---	210451

/*-------------------------------------------------------------------------------*/

void boom(int x, int y)
{

	int s_angle = 180;
	int e_angle = 0;

	int x_rad = 0;
	int y_rad = 0;

	ellipse(x, y - i, s_angle, e_angle, x_rad, y_rad); // Shock-Wave

	ellipse(x + 30, y - 50 - i, s_angle + 20, e_angle + 40, x_rad + 3, y_rad + 50); // Shock-Wave

	ellipse(x - 40, y + 20 - i, s_angle - 90, e_angle + 180, x_rad + 2, y_rad + 30); // Shock-Wave

	ellipse(x + 30, y + 20 - i, s_angle - 90, e_angle + 180, x_rad + 2, y_rad + 30); // Shock-Wave

	ellipse(x + 50, y - 20 - i, s_angle + 40, e_angle + 100, x_rad + 3, y_rad + 40); // Shock-Wave

	ellipse(x - 30, y + 40 - i, s_angle - 60, e_angle + 120, x_rad + 4, y_rad + 35); // Shock-Wave

	circle(x + 20 + i, y - 10, 10); // Debris

	circle(x + 40 - i, y + 20, 10); // Debris

	circle(x + 30 + i, y - 50, 10); // Debris

	delay(10);
}

/*-------------------------------------------------------------------------------*/

// Loading Function	---	210451

/*-------------------------------------------------------------------------------*/

void loadingScreen()
{

	screenBorder();

	// Loading Text

	settextstyle(0, 0, 3);
	outtextxy(70, 50, "Get ready to witness");
	outtextxy(70, 80, "the sinking SHIP!!!");

	// // Outer Circle

	// ellipse(310, 250, 90 + i, 100 + i, 70, 70); // Loading Arcs

	// ellipse(310, 250, 90 + i, 100 + i, 69, 69); // Loading Arcs

	// ellipse(310, 250, 90 + i, 100 + i, 68, 68); // Loading Arcs

	// ellipse(310, 250, 90 + i, 100 + i, 67, 67); // Loading Arcs

	// // Inner Circle

	// ellipse(310, 250, 90 - i, 100 - i, 30, 30); // Loading Arcs

	// ellipse(310, 250, 90 - i, 100 - i, 29, 29); // Loading Arcs

	// ellipse(310, 250, 90 - i, 100 - i, 28, 28); // Loading Arcs

	// ellipse(310, 250, 90 - i, 100 - i, 27, 27); // Loading Arcs

	outtextxy(100, 320, "Loading...");
	rectangle(99, 379, 549, 391);

	for (i = 0; i < 448; i++)
	{
		rectangle(100 + i, 380, 548, 390);
		delay(10);
	}
}

/*-------------------------------------------------------------------------------*/

// Home Screen Function	---	210451

/*-------------------------------------------------------------------------------*/

void homeScreen()
{

	screenBorder();

	settextstyle(0, 0, 4);
	outtextxy(50, 70, "Computer Graphics"); // Title
	outtextxy(50, 130, "  Micro-Project");	 // Title

	//Horizontal Border

	line(0, 210, 640, 210);
	line(0, 211, 640, 211);
	line(0, 212, 640, 212);
	line(0, 213, 640, 213);
	line(0, 214, 640, 214);
	line(0, 215, 640, 215);
	line(0, 216, 640, 216);
	line(0, 217, 640, 217);
	line(0, 218, 640, 218);
	line(0, 219, 640, 219);

	settextstyle(0, 0, 2);
	outtextxy(120, 320, "Abdurrahman Qureshi");
}

/*-------------------------------------------------------------------------------*/

// Border Function	--- 210451

/*-------------------------------------------------------------------------------*/

void screenBorder()
{

	// Top Border

	line(0, 1, 640, 1);
	line(0, 2, 640, 2);
	line(0, 3, 640, 3);
	line(0, 4, 640, 4);
	line(0, 5, 640, 5);
	line(0, 6, 640, 6);
	line(0, 7, 640, 7);
	line(0, 8, 640, 8);
	line(0, 9, 640, 9);
	line(0, 0, 640, 0);

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
}

/*-------------------------------------------------------------------------------*/