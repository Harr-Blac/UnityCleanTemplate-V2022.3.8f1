#if UNITY_EDITOR

using System.IO;
using UnityEditor;

public class CreateScrptTemplates
{
    [MenuItem("Assets/Create/Code/C# Class", priority = 40)]
    public static void CreateClass()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewClass.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewClass.cs");
    }
    [MenuItem("Assets/Create/Code/C# Interface", priority = 41)]
    public static void CreateInterface()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewInterface.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewInterface.cs");
    }
    [MenuItem("Assets/Create/Code/C# Enum", priority = 42)]
    public static void CreateEnum()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewEnum.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewEnum.cs");
    }
    [MenuItem("Assets/Create/Code/C# ScriptableObj", priority = 43)]
    public static void CreateScriptableObj()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewScriptableObj.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewSO.cs");
    }

    [MenuItem("Assets/Create/Code/C# NewSingleton", priority = 44)]
    public static void CreateSingleton()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewSingleton.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewSingleton.cs");
    }
    [MenuItem("Assets/Create/Code/C# NewPersistSingleton", priority = 45)]
    public static void CreatePersistSingle()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewPersistSingleton.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewPersistSingleton.cs");
    }
    [MenuItem("Assets/Create/Code/C# StaticInstance", false, priority = 46)]
    public static void CreateStaticInstance()
    {
        string tempPath = "Assets/Editor/ScriptTemplates/NewStaticInstance.cs.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(tempPath, "NewStaticInstance.cs");
    }


} 
#endif
