#include <iostream>
#include <limits>

#include "counter.h"

int main() {
    using namespace std;

    auto counter = Counter();

    cout << "Enter CTRL + C to exit" << endl;

    while (true) {
        cout << "Select action (number): 1 - increase 2- decrease: ";

        int choice {};

        cin >> choice;

        if (cin.fail()) {
            cout << "Enter number." << endl;
            
            cin.clear();
            cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            continue;
        }

        if (choice == 1) {
            counter.increase();
        }
        else if (choice == 2) {
            counter.decrease();
        }
        else {
            cout << "I don't know this action." << endl;
            continue;
        }

        cout << counter << endl;
    }
}
