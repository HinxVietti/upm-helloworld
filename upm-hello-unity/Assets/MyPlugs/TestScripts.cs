using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class TestScripts
{


    static TestScripts()
    {
        Debug.Log("Unity Loaded . this is " + Application.productName);
    }


}
