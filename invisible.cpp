//compile with -mwindows
/*arguments should be "1" "cut  " or "copy " "C:\...\test\" */
#include <string>
#include <fstream>

int main(int argc, char **argv) {
    if(argc != 4) return 0;
    std::ofstream file;
    std::string filename = "slot" + std::string(argv[1]) + ".txt";
    file.open(filename);
    file << argv[2] + std::string(argv[3]);
    file.close();
    return 0;
}