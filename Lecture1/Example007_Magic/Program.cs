﻿Console.Clear();

int xa = 50;
int ya = 1;

int xb = 1;
int yb = 20;

int xc = 100;
int yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = xb;
int count = 0;

while (count<10000) {
	int what = new Random().Next(0, 3); // может принимать значение 0, 1 или 2
	if(what==0) {
		x = (x + xa) / 2;
		y = (y + ya) / 2;
	}
	if(what==1) {
		x = (x + xb) / 2;
		y = (y + yb) / 2;
	}
	if(what==2) {
		x = (x + xc) / 2;
		y = (y + yc) / 2;
	}
	Console.SetCursorPosition(x, y);
	Console.WriteLine("+");
	count++;
}