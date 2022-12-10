using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScreenResScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(2532, 1170 , FullScreenMode.ExclusiveFullScreen, 60);
    }
}
