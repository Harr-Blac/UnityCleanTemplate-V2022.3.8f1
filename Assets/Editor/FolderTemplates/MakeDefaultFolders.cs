using System.IO;
using UnityEditor;
using UnityEngine;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using static System.IO.Directory;
using static System.IO.Path;
  

public static class MakeDefaultFolders
{
    //Starting folders
    [MenuItem("Tools/Setup/Create Default Folders")]
    public static void CreateFolders()
    {
        Directory("_Project",  "UI", "Levels", "Managers", "Resources");
        Directory("_Project/Actors", "Players", "Enemies", "NPCS");
        Refresh();
    }

    //Create folder architecture from tools menu 
    public static void Directory(string root, params string[] dir)
    {
        var fullpath = Combine(dataPath, root);
        foreach (var newDirectory in dir)
            CreateDirectory(Combine(fullpath, newDirectory));
    }

    //Folders for game objects
    [MenuItem("Assets/Create/CustomFolder/Object Folders", priority = 40)]
    public static void CreateObjectFolders()
    {
        LocalDirectory("_Temp_", "Scripts", "Art", "Data");
        Refresh();
    }

    //Local folder creation in current folder
    public static void LocalDirectory(string root, params string[] dir)
    {
        var fullpath = Combine(AssetDatabase.GetAssetPath(Selection.activeObject), root);
        foreach (var newDirectory in dir)
            CreateDirectory(Combine(fullpath, newDirectory));
    }
}