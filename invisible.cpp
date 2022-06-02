//compile with -mwindows
/*arguments should be "cut  " or "copy " "1" "C:\...\test\" */
#include <string>
#include <fstream>
#include <iostream>

int main(int argc, char **argv) {
    if(argv[1] == "cut  " || argv[1] == "copy ") {
        std::ofstream file ("slot" + std::string(argv[2]) + ".txt");
        file << argv[3] + std::string(argv[4]);
        file.close();
    } else if(argv[1] == "paste") { //why doesnt this work
        std::ifstream file ("slot" + std::string(argv[2]) + ".txt");
        std::string contents;
        file >> contents;
        std::cout << contents << '\n';
        file.close();
    }
    return 0;
}