using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform CameraTranform;

    // Use this for initialization
    private void Start()
    {
        CameraTranform = Camera.main.transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.forward = CameraTranform.forward;
    }
}