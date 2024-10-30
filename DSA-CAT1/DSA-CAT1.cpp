//Author : Felix Muinde.

#include <iostream>
#include <cmath>
using namespace std;

float squareUp(float input) {
    return pow(input, 2);;
}
float getCubed(float input) {
    return pow(input, 3);
}
double areaOfACircle(double radius) {
    return 3.14159 * pow(radius, 2);
}
void isItLeap() {
    int inYear;
    cout << "Enter a year for me to check for leapness: ";
    cin >> inYear;
    if (inYear % 4 == 0) {
        cout << "It is leap!";
    }
    else {
        cout << "This year is not leap!";
    }
}

int main()
{
    int one = 12;
    int two = 2004;
    int three = 2023;
    cout << squareUp(one) << endl;
    cout << getCubed(one) << endl;
    cout << "Area of a circle of radius " << one << " units" << areaOfACircle(one) << endl;

    isItLeap();
}