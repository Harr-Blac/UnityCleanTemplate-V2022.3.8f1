#if UNITY_EDITOR

using System.IO;
using UnityEditor;

public static class CreateTextFile
{
    [MenuItem("Assets/Create/Code/New Text File", priority = 39)]
    private static void CreateNewTextFile()
    {
        string folderGUID = Selection.assetGUIDs[0];
        string projectFolderPath = AssetDatabase.GUIDToAssetPath(folderGUID);
        string folderDirectory = Path.GetFullPath(projectFolderPath);

        using (StreamWriter sw = File.CreateText(folderDirectory + "/NewTextFile.txt"))
        {
            sw.WriteLine(">");
        }

        AssetDatabase.Refresh();
    }
}
#endif