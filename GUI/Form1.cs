using Microsoft.Win32;
namespace GUI;

public partial class Form1 : Form
{
    
    public void reg(bool y_n, bool cascade, string name, string[] values, string[] actions, string location)
    {
        if (!y_n)
        { // remove
            if (!cascade)
            {
                Registry.ClassesRoot.DeleteSubKey(location + "\\shell\\" + name + "\\command");
                Registry.ClassesRoot.DeleteSubKey(location + "\\shell\\" + name);
            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                {
                    Registry.ClassesRoot.DeleteSubKey(location + "\\shell\\" + name + "\\shell\\" + values[i] + "\\command");
                    Registry.ClassesRoot.DeleteSubKey(location + "\\shell\\" + name + "\\shell\\" + values[i]);
                }
                Registry.ClassesRoot.DeleteSubKey(location + "\\shell\\" + name + "\\shell");
                Registry.ClassesRoot.DeleteSubKey(location + "\\shell\\" + name);
            }
        }
        else
        { // add
            RegistryKey reg;
            if (cascade)
            {
                
                reg = Registry.ClassesRoot.CreateSubKey(location + "\\shell\\" + name);
                Registry.ClassesRoot.CreateSubKey(location + "\\shell\\" + name + "\\shell");
                reg.SetValue("MUIVerb", name);
                reg.SetValue("subcommands", "");
                for (int i = 0; i < values.Length; i++)
                {
                    Registry.ClassesRoot.CreateSubKey(location + "\\shell\\" + name + "\\shell\\" + values[i]);
                    reg = Registry.ClassesRoot.CreateSubKey(location + "\\shell\\" + name + "\\shell\\" + values[i] + "\\command");
                    reg.SetValue("", actions[i]);
                }
            }
            else
            {
                Registry.ClassesRoot.CreateSubKey(location + "\\shell\\" + name);
                reg = Registry.ClassesRoot.CreateSubKey(location + "\\shell\\" + name + "\\command");
                reg.SetValue("", actions[0]);
            }
        }
    }



        public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void yes_rmdir_Click(object sender, EventArgs e)
    {
        reg(true, false, "RMDIR", null, new[] {"cmd.exe /c rmdir \"%1\" /Q /S"}, "Directory");
    }

    private void remove_rmdir_Click(object sender, EventArgs e)
    {
        reg(false, false, "RMDIR", null, null, "Directory");
    }

    private void yes_copy_Click(object sender, EventArgs e)
    {
        //System.Reflection.Assembly.GetEntryAssembly().Location
        //place gui and invis/vis executables in same directory
        //search desktop for other notes to add, like compact
        //reg(bool y_n, bool cascade, string name, string[] values, string[] actions, string location)
    }

    private void no_copy_Click(object sender, EventArgs e)
    {

    }

    private void yes_sym_Click(object sender, EventArgs e)
    {
        //string location = System.Reflection.Assembly.GetEntryAssembly().Location;
        //string dir = '\"' + location.Substring(0, location.LastIndexOf("GUI.dll")) + "sym.exe\"" + " \"%1\"";
        //reg(true, true, "Batch Symlink", new[] {"Symlink", "Symlink but copy executables"}, new[] {dir, dir + " \"copy\""}, "Directory");
    }

    private void no_sym_Click(object sender, EventArgs e)
    {
        //reg(false, true, "Batch Symlink", null, null, "Directory");
    }
}
