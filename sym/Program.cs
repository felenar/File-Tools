namespace sym;

static class Program
{
    [STAThread]
    static void Main()
    {
        //variables
        string[] args = Environment.GetCommandLineArgs();
        string source = args[1];
        if (source[source.Length - 1] == '\"')
            source = source.Substring(1, source.Length - 2);
        if (source[source.Length - 1] == '\\')
            source = source.Substring(0, source.Length - 1);
        string dest = source + " (Sym)";
        string[] list_files = Directory.GetFiles(source, "*", SearchOption.AllDirectories);
        string[] list_folders = System.IO.Directory.GetDirectories(source, "*", SearchOption.AllDirectories);

        //Create directories
        for (int i = 0; i < list_folders.Length; i++)
        {
            list_folders[i] = list_folders[i].Substring(source.Length);
            Directory.CreateDirectory(dest + "\\" + list_folders[i]);
        }

        //format file list
        for (int i = 0; i < list_files.Length; i++)
        {
            list_files[i] = list_files[i].Substring(source.Length);
        }

        //create symlinks!
        for (int i = 0; i < list_files.Length; i++)
            if (list_files[i].Contains("\\"))
                File.CreateSymbolicLink(dest + list_files[i], source + list_files[i]);

        //create executables
        if(args[1] == "copy") {
            for (int i = 0; i < list_files.Length; i++)
                if (list_files[i].Contains(".exe"))
                {
                    File.Delete(dest + list_files[i]);
                    File.Copy(source + list_files[i], dest + list_files[i]);
                }
        }
    }    
}