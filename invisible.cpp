//compile with -mwindows
/*arguments should be "cut  " or "copy " "1" "C:\...\test\" 
or "paste" "1 or 2" "C:\...\test" */
#include <string>
#include <fstream>
#include <windows.h>

int main(int argc, char **argv) {
    //make first argument a string
    std::string check = argv[1];

    //format current directory of exe
    std::string dir = argv[0];
    if (dir[dir.length() - 1] == '\"')
        dir = dir.substr(1, dir.length() - 2);
    dir = dir.substr(0, dir.length() - 13);

    if(check == "copy") {
        //create slot file
        std::ofstream file(dir + argv[2] + ".txt");
        file << std::string(argv[3]);
        file.close();
    } if(check == "paste") {      
        //read slot file  
        std::ifstream file (dir + argv[2] + ".txt");
        std::string contents;
        std::getline(file, contents);
        file.close();

        //format the destination
        std::string folderDir = argv[3];
        if (!(folderDir.find('\\') != std::string::npos)) folderDir = folderDir.substr(0, 2);
        folderDir = folderDir + contents.substr(contents.find_last_of('\\'));

        //run commands
        std::string command = "robocopy.exe \"" + contents + "\" " + folderDir + " /E /sl";        
        system(command.c_str());    
         
        //testing for later
        //ShellExecute(0, "runas", command.c_str().substr(0,12), command.c_str().substr(13), 0, SW_SHOWNORMAL);
        //ShellExecute(0, "runas", "cmd.exe", "/k " + command.c_str(), 0, SW_SHOWNORMAL);
        // HINSTANCE result = ShellExecute(0, "runas", "notepad.exe", 0, 0, SW_SHOWNORMAL);
    } if(check == "path") {
        //read path
        HKEY key;
        DWORD value_length;
        RegOpenKey(HKEY_CURRENT_USER, "Environment",&key);
        RegQueryValueEx(key, "Path", NULL, 0, 0, &value_length);
    	TCHAR * tvalue = new TCHAR [value_length + sizeof(argv[2]) + 1];
        RegQueryValueEx(key, "Path", NULL, 0, (LPBYTE)tvalue, &value_length);

        //concatenate the text to go in the new path
        std::string svalue = tvalue;
        svalue = svalue + ';';
        svalue = svalue + argv[2];

        //set the path and clean up variables
        RegSetValueExA(key, "Path", 0, REG_EXPAND_SZ, (const BYTE*)svalue.c_str(), svalue.length());
        RegCloseKey(key);
        delete[] tvalue;

        //tell open windows that path variable has changed
        SendMessageTimeout(HWND_BROADCAST,WM_SETTINGCHANGE, 0, (LPARAM)TEXT("Environment"), 0, 1000, 0);
    } return 0;
}