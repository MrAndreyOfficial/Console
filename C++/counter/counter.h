#ifndef COUNTER
#define COUNTER
#include <iostream>

    class Counter
    {
    public:
        void increase(int count = 1) {
            if (isValidCount(count) == false)
            {
                std::cout << "Count is less than 1" << std::endl;
                return;
            }

            m_count += count;
        }
        
        void decrease(int count = 1) {
            if (isValidCount(count) == false)
            {
                std::cout << "Count is less than 1" << std::endl;
                return;
            }

            m_count -= count;
        }

        friend std::ostream& operator <<(std::ostream& out, Counter& counter) {
            out << "Count: " << counter.m_count;

            return out;
        }
    private:
        int m_count;

        bool isValidCount(int count) {
            return count > 0;
        }
    };
#endif
