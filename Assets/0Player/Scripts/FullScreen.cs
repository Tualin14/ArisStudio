﻿using UnityEngine;

public class FullScreen : MonoBehaviour
{
    int r = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (r == 1)
            {
                Screen.SetResolution(1280, 800, false);
            }
            else if (r == 2)
            {
                Screen.SetResolution(1920, 1080, false);
            }
            else if (r == 3)
            {
                Screen.SetResolution(2560, 1440, false);
            }
            else if (r == 4)
            {
                Screen.SetResolution(3840, 2160, false);
                r = 0;
            }
            r++;
        }
    }
}
