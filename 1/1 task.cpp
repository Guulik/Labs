#include <iostream>

using namespace std;

int main()
{
	//taks 1
	float a, b, S,P;
	cout << "Enter length and width of the rectangle: ";
	cin >> a >> b;
	S = a * b;
	P = 2 * (a + b);
	cout << "Square of a rectangle = " << S << "\nPerimeter of a rectangle = " << P;
	return 0;
}