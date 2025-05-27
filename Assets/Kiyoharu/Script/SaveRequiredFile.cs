using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.Rendering.STP;

public class SaveRequiredFile : MonoBehaviour
{
    void Start()
    {
        //// Check if default config folder exists
        //string folderPath = Application.persistentDataPath;
        //if (!Directory.Exists(folderPath))
        //{
        //    Directory.CreateDirectory(folderPath); // If you don't have it, make one
        //}


        //// Check whether there is a check file
        //string filePath = Application.persistentDataPath + "/check.txt";
        //if (!File.Exists(filePath))
        //{
        //    //Debug.LogWarning("配置文件不存在: " + filePath);
        //    string createcontent = "checkDeployment=false";// If you don't have it, make one and reset
        //    File.WriteAllText(filePath, createcontent);
        //    return;
        //}


        //// Verify using the check file
        //Dictionary<string, string> configMap = new Dictionary<string, string>();
        //string[] lines = File.ReadAllLines(filePath);

        //foreach (string line in lines)
        //{
        //    if (string.IsNullOrWhiteSpace(line) || !line.Contains("="))
        //        continue;

        //    string[] parts = line.Split('=');
        //    if (parts.Length >= 2)
        //    {
        //        string key = parts[0].Trim();
        //        string value = parts[1].Trim();
        //        configMap[key] = value;
        //    }
        //}


        //if (configMap["checkDeployment"] == "false")
        //{
        //string sourceFolder = Path.Combine(Application.streamingAssetsPath, "MyFolder"); 
        //string destinationFolder = Path.Combine(Application.persistentDataPath, "MyFolder");


        //    //処理完了
        //    string content = "checkDeployment=true";
        //    File.WriteAllText(filePath, content);
        //}

        Debug.Log(Application.streamingAssetsPath);

    }


    // Recursive Copy Functions Typically Used by Platforms
    void CopyFolder(string sourcePath, string targetPath)
    {
        if (!Directory.Exists(targetPath))
        {
            Directory.CreateDirectory(targetPath);
        }

        foreach (string file in Directory.GetFiles(sourcePath))
        {
            string fileName = Path.GetFileName(file);
            string targetFilePath = Path.Combine(targetPath, fileName);
            File.Copy(file, targetFilePath, true);
        }

        foreach (string dir in Directory.GetDirectories(sourcePath))
        {
            string dirName = Path.GetFileName(dir);
            string targetSubDir = Path.Combine(targetPath, dirName);
            CopyFolder(dir, targetSubDir);
        }
    }

    //// Android special handling
    //System.Collections.IEnumerator CopyFolderAndroid(string sourceFolder, string targetFolder)
    //{
    //    if (!Directory.Exists(targetFolder))
    //    {
    //        Directory.CreateDirectory(targetFolder);
    //    }

    //    // StreamingAssets files and paths can't be listed by Directory.GetFiles, but manually.
    //    string[] fileNames = { "myfile1.txt", "myfile2.txt" }; // List of filenames you want to copy
    //    foreach (string fileName in fileNames)
    //    {
    //        string sourceFile = Path.Combine(sourceFolder, fileName);
    //        string destFile = Path.Combine(targetFolder, fileName);

    //        using (var www = UnityEngine.Networking.UnityWebRequest.Get(sourceFile))
    //        {
    //            yield return www.SendWebRequest();
    //            if (www.result == UnityEngine.Networking.UnityWebRequest.Result.Success)
    //            {
    //                File.WriteAllBytes(destFile, www.downloadHandler.data);
    //            }
    //            else
    //            {
    //                Debug.LogError("Reproduction Failure: " + sourceFile + " → " + destFile);
    //            }
    //        }
    //    }

    //    Debug.Log("Android Platform folder copy complete：" + targetFolder);
    //}
}
