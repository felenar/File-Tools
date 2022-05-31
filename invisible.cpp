//compile with -mwindows

#include <fstream>

int main() {
    std::ofstream file;
    file.open("test.txt");
    file << "test";
    file.close();
    return 0;
}