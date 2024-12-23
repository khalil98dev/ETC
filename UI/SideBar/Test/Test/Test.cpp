
#include <iostream>
using namespace std; 


bool Test(bool f)
{

    return (f > 10) ?false : true;

}

int main()
{


    bool f = false; 
    if (Test(f))
        cout << "Correct" << endl;
    else
        cout << "Incorrect" << endl; 





}

