using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public void LoadSingleLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Build");
    }
}