using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class CameraSwitcher : MonoBehaviour
{
    public List<Camera> cameras = new List<Camera>();

    private int currentCameraIndex = 0;

    void Start()
    {
        SetActiveCamera(0);
    }

    void Update()
    {
        for (int i = 0; i < 9; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                if (i < cameras.Count)
                {
                    SetActiveCamera(i);
                }
            }
        }
    }

    void SetActiveCamera(int index)
    {
        if (currentCameraIndex < cameras.Count)
        {
            cameras[currentCameraIndex].enabled = false;
        }

        currentCameraIndex = index;
        cameras[currentCameraIndex].enabled = true;
    }
}
