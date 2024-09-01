using UnityEditor;
using System.IO;

public class ScriptModificationProcessor : UnityEditor.AssetModificationProcessor
{
    public static void OnWillCreateAsset(string path)
    {
        if (!path.EndsWith(".cs.meta"))
        {
            return;
        }

        string originalFilePath = AssetDatabase.GetAssetPathFromTextMetaFilePath(path);
        string file = File.ReadAllText(originalFilePath);

        //change whatever you want (you can add stuff below, just be sure to add the tags in the script template too!)
        //file = file.Replace("#CREATIONDATE#", System.DateTime.Now + "");
        file = file.Replace("#CREATIONDATE#", System.DateTime.Now.ToString("dd MMMM yyyy"));
        //file = file.Replace("#CREATIONDATE#", System.DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        file = file.Replace("#PROJECTNAME#", PlayerSettings.productName);
        //file = file.Replace("#SMARTDEVELOPERS#", PlayerSettings.companyName);

        //Write the changes in the new script
        File.WriteAllText(originalFilePath, file);
        AssetDatabase.Refresh();

        //path = path.Replace(".meta", "");
        //int index = path.LastIndexOf(".");
        //string file = path.Substring(index);
        //Debug.Log(path + "  -  "+ index + "  -  " + file); //+ "" + "" + ""

        //if (file != ".cs" && file != ".js" && file != ".boo") return;

        //index = Application.dataPath.LastIndexOf("Assets");
        //path = Application.dataPath.Substring(0, index) + path;
        //file = System.IO.File.ReadAllText(path);
        //Debug.Log(path + "  -  " + index + "  -  " + file); //+ "" + "" + ""
        //Debug.Log("nopr"); //+ "" + "" + ""


        //file = file.Replace("#CREATIONDATE#", DateTime.Now.ToString());

        //System.IO.File.WriteAllText(path, file);
        //AssetDatabase.Refresh();
    }
}