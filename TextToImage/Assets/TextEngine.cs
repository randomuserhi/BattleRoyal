using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class TextEngine : MonoBehaviour
{
    public static TMPConsole Console;
    private Task MainThread;
    private CancellationTokenSource MainThreadCancelToken = new CancellationTokenSource();

    public bool TakeImage = false;

    private void Start()
    {
        //Get Console
        Console = GameObject.FindGameObjectWithTag("TMPConsole").GetComponent<TMPConsole>();

        Loader.LoadAllSprites(); //Load all sprites

        MainThread = Task.Run(() => { Game.Start(MainThreadCancelToken.Token); });
    }

    private void RenderLoop()
    {

    }

    private void Update()
    {
        RenderLoop();
        Console.Render();

        if (TakeImage)
        {
            TakeImage = false;
            TakeScreenShot();
        }
    }

    private void TakeScreenShot()
    {
        ScreenCapture.CaptureScreenshot(@"C:\Users\LenovoY720\Desktop\UnityScreeny.png");
        Debug.Log("ImageTaken");
    }

    private void OnApplicationQuit()
    {
        MainThreadCancelToken.Cancel();
        MainThreadCancelToken.Dispose();
    }
}
