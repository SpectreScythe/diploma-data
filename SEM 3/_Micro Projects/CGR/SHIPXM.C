
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

int i, x = 0, y = 300; // Global Variables

/*-------------------------------------------------------------------------------*/

// 210454

/*-------------------------------------------------------------------------------*/

void bfa(int x, int y, int ncolor, int dcolor);
void shipwreck(int x, int y);
void ship(int i);
void stars();
void wave();

/*-------------------------------------------------------------------------------*/

// 210451

/*-------------------------------------------------------------------------------*/

void boom();
void bigBoom();
void meteor(int i);
void indexPage();
void homeScreen();
void loadingScreen();

/*-------------------------------------------------------------------------------*/

// Main Function

/*-------------------------------------------------------------------------------*/

int main()
{
	int gd = DETECT, gm;
	initgraph(&gd, &gm, " ");

	indexPage();

	/*

	for(i = 0 ; i < 100 ; i++)
	{
		homeScreen();
		delay(5);
	}

	outtextxy(400, 400, "Press any key to continue...");
	getch();

	cleardevice();

	for (i = 0; i < 360; i++)
	{

		loadingScreen();
		delay(8);
	}

	settextstyle(0, 0, 1);
	outtextxy(400, 400, "Press any key to continue...");
	getch();

	for (i = 0; i < 280; i++)
	{
		ship(i);
		stars();
		meteor(i);
		wave();
		delay(10);
		cleardevice();
	}

	//AFTER COLLISION

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

	*/

	closegraph();

	return 0;
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

void wave()
{

	line(0, y + 50, getmaxx(), y + 50); // wave
	setfillstyle(9, LIGHTBLUE);
	floodfill(x, y + 60, 15);
}

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

	ellipse(x, y - i, s_angle, e_angle, x_rad, y_rad);	// Shock-Wave

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

	// Loading Text

	settextstyle(0, 0, 3);
	outtextxy(70, 50, "Get ready to witness");
	outtextxy(70, 80, "the sinking SHIP!!!");

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

/*-------------------------------------------------------------------------------*/

// Home Screen Function	---	210451

/*-------------------------------------------------------------------------------*/

void homeScreen()
{
	settextstyle(0 , 0 , 4);
	outtextxy(50 , 100 , "Computer Graphics");	// Title
	outtextxy(50 , 160 , "  Micro-Project");	// Title

	settextstyle(0 , 0 , 2);
	outtextxy(120 , 250 , "Guided By Mr. Zaid");	// Faculty

	settextstyle(0 , 0 , 1);
	outtextxy(120 , 300 , "210451");	//Participants Roll No
	outtextxy(120 , 320 , "210454");	//Participants Roll No
	outtextxy(120 , 340 , "210451");	//Participants Roll No
}

/*-------------------------------------------------------------------------------*/

void indexPage(){
	rectangle(80 , 300 , 180 , 400);
	floodfill(81 , 390);
}