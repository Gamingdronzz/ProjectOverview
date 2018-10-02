using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTagManager : SingletonMonoBehaviour<MyTagManager>
{
    public string Building = "Buildings";

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}