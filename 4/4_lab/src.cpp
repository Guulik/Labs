#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	//taks 1
	float a, b, S,P;
	cout << "Task 1 \nEnter length and width of the rectangle: ";
	cin >> a >> b;
	S = a * b;
	P = 2 * (a + b);
	cout << "Square of a rectangle = " << S << "\nPerimeter of a rectangle = " << P;

	//task 2
	float d,L,pi=3.14;
	cout << "\nTask 2\nEnter diameter: ";
	cin >> d;
	L = d * pi;
	cout << "Length of circle = " << L;
	

	//task 3
	float x, y, ar;
	cout << "\nTask 3\nEnter 2 numbers: ";
	cin >> x >> y;
	ar = (x + y) / 2;
	cout << "Average = " << ar;
	
	//task 4
	float q, w;
	cout << "\nTask 4\nEnter 2 numbers: ";
	cin >> q >> w;
	cout << "Sum = " << q*q+w*w << " Diff = " << q*q-w*w << " Prod = " << q*q*w*w << " Div = " <<(q*q)/(w*w);


	//task 5
	float e, r;
	cout << "\nTask 5\nEnter 2 numbers: ";
	cin >> e >> r;
	cout << "Sum = " << abs(e)+abs(r) << " Diff = " << abs(e) - abs(r) << " Prod = " << abs(e) * abs(r) << " Div = " << abs(e) / abs(r);
	return 0;
}