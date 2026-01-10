using System.IO;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName))
        {
            System.Console.WriteLine("Folder Already Exists...");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            System.Console.WriteLine("Folder Created Successfully!");
        }
    }

    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo = new DriveInfo(driveName);
        System.Console.WriteLine($"Drive Name : {dInfo.Name}");
        System.Console.WriteLine($"Drive Type : {dInfo.DriveType}");
        System.Console.WriteLine($"Drive Format : {dInfo.DriveFormat}");
        System.Console.WriteLine($"Drive Available Space : {dInfo.TotalFreeSpace}");
        System.Console.WriteLine($"Drive Size : {dInfo.TotalSize}");
        
    }

    public void PathDemoFunc()
    {
        // @ symbol helps to indentify the \ as path separator not escape sequence
        string s = @"C:\temp\MyData.text\machine.config\Alok\Dummy.Data\ABC.cs";
        System.Console.WriteLine(Path.GetFileName(s));
        System.Console.WriteLine(Path.GetTempPath());
    }
}