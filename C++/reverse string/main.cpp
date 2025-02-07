#include <iostream>

void reverseString(std::string& str);

int main() {
	std::string text{ "C#" };

	reverseString(text);

	std::cout << text;
}

void reverseString(std::string& str) {
	int start = 0;
	int end = str.length() - 1;
	
	while (start < end) {
		std::swap(str[start], str[end]);

		start++;
		end--;
	}
}
