
string defaultPath = "C:\\Users\\pil02\\Desktop\\Irina";//путь ккорневой папке
PrintDirectory(new DirectoryInfo(defaultPath),"",true);
static void PrintDirectory(DirectoryInfo directory,string indent,bool LastDirectory)
{
    Console.Write(indent);
    if (LastDirectory)
    {
        Console.Write("└──");
        indent += " ";
    }
    else
    {
        Console.Write("│───");
        indent += "│";
    }
    Console.WriteLine(directory.Name);

    DirectoryInfo[] subDirectories = directory.GetDirectories();
    for (int i = 0; i < subDirectories.Length; i++)
    {
        PrintDirectory(subDirectories[i], indent, i == subDirectories.Length - 1);
    }
}