//https://www.kemomimi.dev/unity/1492/

// using System;
// using System.IO;
// using System.Diagnostics;
// using UnityEditor;
// using UnityEngine;

// public class StartBat :
// {
// private static readonly string batPath = Application.streamingAssetsPath + "/start.bat";
// //private static readonly string batPath = Application.dataPath + "/hoge.bat";
// private Process p;
// /// <summary>
// /// 起動
// /// </summary>
// public void StartExternalApp(string arg)
// {
// p = new Process();
// p.StartInfo.FileName = batPath;
// p.StartInfo.Arguments = arg;  //引数
// p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
// p.StartInfo.CreateNoWindow = false;   //ここを有効にするとcmdのウィンドウが非表示のまま実行される
// p.StartInfo.UseShellExecute = true;
// p.Start();
// }
// /// <summary>
// /// 停止
// /// </summary>
// public void StopExternalApp()
// {
// var processes = Process.GetProcessesByName("node");
// foreach (var process in processes)
// {
// process.Kill();
// }
// }
// }


// using System;
// using System.IO;
// using System.Diagnostics;
// using UnityEditor;
// using UnityEngine;


//     [InitializeOnLoad]
//     public class StarBat
//     {
//         private static readonly string batPath = Application.dataPath + "/hoge.bat";
//         private static Process p;
        

//         static StarBat()
//         {

//                 ExecuteBat();
//                 AssetDatabase.Refresh();

//         }
        
//         private static void ExecuteBat()
//         {
//             p = new Process();
//             p.StartInfo.FileName = batPath;
//             p.StartInfo.Verb = "RunAs";
//             p.StartInfo.UseShellExecute = true;
//             p.Start();
//             p.WaitForExit();  //これを忘れると処理終了を待たずに何回も実行されることになるので注意
//         }
//     }

//https://jj-blues.com/cms/wantto-changedirectory/
// using UnityEditor;
// using System.Diagnostics;

// public class EditorRunTerminal
// {
//     [MenuItem("Window/Run Terminal %t")]
//     static void RunTerminal()
//     {
//         Process p = new Process();
//         p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
//         p.StartInfo.Arguments = "/k cd Assets";
//         p.Start();
//     }
// }

//https://dobon.net/vb/dotnet/process/openfile.html
using System;
using System.IO;
using System.Diagnostics;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

  
public class StartBat : MonoBehaviour
{
public void OnClickStartButton()
{
string batPath = Application.dataPath + "/hoge.bat";
Process p = new Process();
p.StartInfo.FileName = batPath;
p.StartInfo.Verb = "RunAs";　//管理者として実行する場合
 
p.Start();
}
}