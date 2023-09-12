#include <iostream.h>
#include <conio.h>
class polygon
{
public:
    float width, height;
    void initialise(float a, float b)
    {
        width = a;
        height = b;
    }
    virtual int area(void) = 0;
};
class rectangle : public polygon
{
public:
    int area()
    {
        return (width * height);
    }
};
class triangle : public polygon
{
public:
    int area()
    {
        return (0.5 * width * height);
    }
};
void main()
{
    rectangle r;
    triangle t;
    clrscr();
    polygon *m1, *m2;
    m1 = &r;
    m2 = &t;
    m1->initialise(4, 3);
    m2->initialise(5, 2);
    cout << "Area of rectangle:" << m1->area() << endl;
    cout << "Area of triangle:" << m2->area() << endl;
    getch();
}
