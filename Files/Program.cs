

//string filePath = @"C:\Example\MyFile.txt";
//FileInfo fileInfo = new FileInfo(filePath);
//// Check if the file exists
//if (fileInfo.Exists)
//{
//    // Read the contents of the file (same as File.ReadAllText)
//    string fileContent = fileInfo.ReadAllText();
//    Console.WriteLine("File Contents:");
//    Console.WriteLine(fileContent);

//    // Get the size of the file
//    long fileSizeInBytes = fileInfo.Length;
//    Console.WriteLine($"File Size: {fileSizeInBytes} bytes");

//    // Copy the file to a new location
//    string destinationPath = @"D:\\Destination\\MyFile.txt";
//    fileInfo.CopyTo(destinationPath);

//    // Move the file to a different location
//    string newLocation = @"E:\\NewLocation\\MyFile.txt";
//    fileInfo.MoveTo(newLocation);

//    // Delete the file
//    fileInfo.Delete();
//    Console.WriteLine("File deleted.");
//}
//else
//{
//    Console.WriteLine("File does not exist.");
//}

using System.IO.Enumeration;

string directoryName = "Papka";
string path = @"C:\Users\User\Desktop\";
string dirPath = path + directoryName + MakeDirCopies(path, directoryName);

//DirectoryInfo dir1 = new(dirPath);
//dir1.Create();

List<DirectoryInfo> dirList = new();
int numberOfDirs = 3;
for (int i = 0; i < numberOfDirs; i++)
{
    dirList.Add(new DirectoryInfo(path + directoryName + MakeDirCopies(path, directoryName)));
    dirList[i].Create();
}

//Thread.Sleep(5000);
//for (int i = 0; i < numberOfDirs; i++)
//{
//    dirList[i].Delete();
//}

string fileName = "file";
string filePath = ;









string MakeDirCopies(string path, string directoryName)
{
    bool copyFlag = false;
    int maxCopyNumber = 0;

    foreach (var dir in Directory.GetDirectories(path))
        if (dir.Contains(directoryName))
        {
            if(int.TryParse(dir.Substring(dir.IndexOf(directoryName) + 
                directoryName.Length), out int result))
                maxCopyNumber = Math.Max(maxCopyNumber, result);

            copyFlag = true;
        }
    
    return copyFlag ? (maxCopyNumber + 1).ToString() : string.Empty;
}

string NumberFileCopies(string path, string fileName)
{

    bool copyFlag = false;
    int maxCopyNumber = 0;

    foreach (var file in Directory.GetFiles(path))
        if (file.Contains(fileName))
        {
            if (int.TryParse(file.Substring(file.IndexOf(fileName) +
                fileName.Length), out int result))
                maxCopyNumber = Math.Max(maxCopyNumber, result);

            copyFlag = true;
        }

    return copyFlag ? (maxCopyNumber + 1).ToString() : string.Empty;
}
