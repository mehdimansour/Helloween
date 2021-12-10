using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Camera.main.aspect = 4 / 3;
        Screen.SetResolution(1024, 768, true);
    }
}
