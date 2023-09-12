/*-------------------------------------------------------------------------------*/

// Header Files

/*-------------------------------------------------------------------------------*/

#include <iostream>
#include <conio.h>
#include <windows.h>
#include <dos.h>
#include "MMSystem.h"
#include <graphics.h>

using namespace std;

/*-------------------------------------------------------------------------------*/

// GLOBAL DECLARATIONS


int i;

/*-------------------------------------------------------------------------------*/

// Class Main

/*-------------------------------------------------------------------------------*/

class MAIN
{
private:

	int stx, sty, enx, eny, stx1 = 70, sty1 = 130;

public:
	
	void completekey(int stx, int sty, int decision)
	{
		line(stx + 30, sty, stx + 30, sty + 200);	// second key border
		line(stx + 60, sty + 101, stx + 60, sty + 200);	// third key border
		
		setcolor(8);
		setcolor(WHITE);
		
		rectangle(stx + 50, sty + 1, stx + 70, sty + 100);	// mid small key2
		
		setfillstyle(SOLID_FILL, 8);
		floodfill(stx + 51, sty + 99, WHITE);
		
		setcolor(WHITE);
		
		line(stx + 90, sty, stx + 90, sty + 200);	// third key border
		
		stx = stx + 30;
	}

	void operations(int stx1, int sty1)
	{
		setfillstyle(SOLID_FILL, 7);
		floodfill(stx1 + 1, sty1 - 1, WHITE);
		
		delay(150);
		
		setfillstyle(SOLID_FILL, BLACK);
		floodfill(stx1 + 1, sty1 - 1, WHITE);
	}
	
	void homeScreen()
{
	line(0, 196, 640, 196);
	line(0, 197, 640, 197);
	line(0, 198, 640, 198);
	line(0, 199, 640, 199);
	line(0, 200, 640, 200);
	line(0, 201, 640, 201);
	line(0, 202, 640, 202);
	line(0, 203, 640, 203);
	line(0, 204, 640, 204);

	outtextxy(250, 100, "OOP");	// Title
	outtextxy(50, 160, "  Micro-Project");	// Title

	outtextxy(120, 250, "Guided By Ms. Zeba");	// Faculty

	outtextxy(120, 320, "210422");	// Participants Roll No
	outtextxy(120, 300, "210451"); 	// Participants Roll No
	
	getch();
	cleardevice();
}

/*-------------------------------------------------------------------------------*/

// Loading Function

/*-------------------------------------------------------------------------------*/

void loadingScreen()
{
	setcolor(15);

	rectangle(50, 20, 530, 160);
	outtextxy(90, 70, "Your Piano");
	outtextxy(120, 100, "is Processing!!!");

	outtextxy(542, 40, " * Sorry,");
	outtextxy(542, 55, " we have");
	outtextxy(542, 70, " only two");
	outtextxy(542, 85, " GigaBytes");
	outtextxy(542, 100, " of RAM ");
	outtextxy(542, 115, " in this");
	outtextxy(542, 130, " computer *");

	outtextxy(40, 250, " Get ready to play the P-I-A-N-O!!!");

	outtextxy(100, 350, "Loading...");
	rectangle(99, 379, 549, 391);

	for (int i = 0; i < 448; i++)
	{
		setcolor(15);
		rectangle(100 + i, 380, 548, 390);
		delay(10);
	}

	setcolor(15);

	outtextxy(400, 430, "Press any key to continue...");
	getch();
	cleardevice();
}


	/*-------------------------------------------------------------------------------*/

	// Input Function

	/*-------------------------------------------------------------------------------*/

	void getdata(int stx, int sty)
	{
		cout << "\n\n\t\t\t\tDIGITAL PIANO";
		cout << "\n\n\t\t\t\t210451 - Abdurrahman Qureshi";
		cout << "\n\n\t\t\t\t210451 - Abdullah Bagdadi";
		cout << "\n\n\t\t\t\tEnter a key/or multiple keys\n ";
		cout << "\n\t\t\t\tPress 'Y' to exit\n\n";

		char ch, t = 'Y';
		while (1)
		{
			cout<<"\t\t\t\t";

			ch = getchar();
			
			if (ch == 'Y')
			{
				cout << "Exit Complete";
				break;
			}

			stx1 = stx - 17;
			sty1 = sty + 180;

			switch (ch)
			{

			case 'a':	//Key A
				operations(stx1, sty1);
				PlaySound("a.wav", NULL, SND_FILENAME);
				break;

			case 'b':	//Key B
				stx1 = stx1 + 17;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("b.wav", NULL, SND_FILENAME);
				break;

			case 'c':	//Key C
				stx1 = stx1 + 50;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("c.wav", NULL, SND_FILENAME);
				break;
				
			case 'd':	//Key D
				stx1 = stx1 + 83;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("d.wav", NULL, SND_FILENAME);
				break;
			
			case 'e':	//Key E
				stx1 = stx1 + 116;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("e.wav", NULL, SND_FILENAME);
				break;
			
			case 'f':	//Key F
				stx1 = stx1 + 149;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("f.wav", NULL, SND_FILENAME);
				break;
			
			case 'g':	//Key G
				stx1 = stx1 + 182;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("g.wav", NULL, SND_FILENAME);
				break;
			
			case 'h':	//Key H
				stx1 = stx1 + 215;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("h.wav", NULL, SND_FILENAME);
				break;
			
			case 'i':	//Key I
				stx1 = stx1 + 248;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("i.wav", NULL, SND_FILENAME);
				break;
			
			case 'j':	//Key J
				stx1 = stx1 + 281;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("j.wav", NULL, SND_FILENAME);
				break;
			
			case 'k':	//Key K
				stx1 = stx1 + 314;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("k.wav", NULL, SND_FILENAME);
				break;
			
			case 'l':	//Key L
				stx1 = stx1 + 340;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("l.wav", NULL, SND_FILENAME);
				break;
			
			case 'm':	//Key M
				stx1 = stx1 + 373;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("m.wav", NULL, SND_FILENAME);
				break;
			
			case 'n':	//Key N
				stx1 = stx1 + 400;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("n.wav", NULL, SND_FILENAME);
				break;
			
			case 'o':	//Key O
				stx1 = stx1 + 433;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("o.wav", NULL, SND_FILENAME);
				break;
			
			case 'p':	//Key P
				stx1 = stx1 + 455;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("p.wav", NULL, SND_FILENAME);
				break;
			
			case 'q':	//Key Q
				stx1 = stx1 + 488;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("q.wav", NULL, SND_FILENAME);
				break;
			
			case 'u':	//Key U
				stx1 = stx1 + 521;
				sty1 = sty1 - 1;
				operations(stx1, sty1);
				PlaySound("r.wav", NULL, SND_FILENAME);
				break;
			}
		}
		MAIN::piano(stx, sty, enx, eny);
	}

	/*-------------------------------------------------------------------------------*/

	// Piano Function

	/*-------------------------------------------------------------------------------*/

	void piano(int stx, int sty, int enx, int eny)
	{

        
		int cstx = stx, csty = sty, cenx = enx, ceny = eny;
		char i = 'a';
		rectangle(stx, sty, enx, eny);	// body

		setcolor(WHITE);	// firstkey
		line(stx + 30, sty + 101, stx + 30, sty + 200);	// first key border
		setcolor(8);
		setcolor(WHITE);
		rectangle(stx + 40, sty + 1, stx + 20, sty + 100);	// mid small key1
		setfillstyle(SOLID_FILL, 8);
		floodfill(stx + 31, sty + 99, WHITE);
		setcolor(WHITE);
		
		stx = stx + 30;	// firstkey
		completekey(stx, sty, 1);
		completekey(stx + 60, sty, 2);
		completekey(stx + 120, sty, 3);
		completekey(stx + 180, sty, 4);
		completekey(stx + 240, sty, 5);
		completekey(stx + 300, sty, 6);
		completekey(stx + 360, sty, 7);
		completekey(stx + 420, sty, 8);

		outtextxy(stx - 17, sty + 180, "a");
		outtextxy((stx + 30) - 17, sty + 180, "b");
		outtextxy((stx + 60) - 17, sty + 180, "c");
		outtextxy((stx + 90) - 17, sty + 180, "d");
		outtextxy((stx + 120) - 17, sty + 180, "e");
		outtextxy((stx + 150) - 17, sty + 180, "f");
		outtextxy((stx + 180) - 17, sty + 180, "g");
		outtextxy((stx + 210) - 17, sty + 180, "h");
		outtextxy((stx + 240) - 17, sty + 180, "i");
		outtextxy((stx + 270) - 17, sty + 180, "j");
		outtextxy((stx + 300) - 17, sty + 180, "k");
		outtextxy((stx + 330) - 17, sty + 180, "l");
		outtextxy((stx + 360) - 17, sty + 180, "m");
		outtextxy((stx + 390) - 17, sty + 180, "n");
		outtextxy((stx + 420) - 17, sty + 180, "o");
		outtextxy((stx + 450) - 17, sty + 180, "p");
		outtextxy((stx + 480) - 17, sty + 180, "q");
		outtextxy((stx + 510) - 17, sty + 180, "u");
	}
};

/*-------------------------------------------------------------------------------*/

// Main Function

/*-------------------------------------------------------------------------------*/

int main()
{
	int gd = DETECT, gm;
	int stx = 40, sty = 100, enx = 580, eny = 300;
	initgraph(&gd, &gm, (char *)"");

	MAIN s;

	s.homeScreen();
	s.loadingScreen();

	s.piano(stx, sty, enx, eny);
	s.getdata(71, 99);

	getch();
	
	closegraph();
	
	return 0;
}

/*-------------------------------------------------------------------------------*/

// Program End

/*-------------------------------------------------------------------------------*/