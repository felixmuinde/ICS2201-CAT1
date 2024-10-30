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
int main()
{
    int one = 12;
    cout << squareUp(12) << endl;
    cout << getCubed(12) << endl;
}