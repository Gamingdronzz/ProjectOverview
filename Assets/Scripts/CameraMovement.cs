using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private bool isCamMoving;
    public float speed = 40f;
    private int screenWidth;
    private int screenHeight;
    public int MovementMarginWidth = 30;
    public int MovementMarginHeight = 30;

    private void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;

        Debug.Log("Screen size = " + screenWidth + "," + screenHeight);
    }

    private void Update()
    {
        MoveCam();
    }

    private void MoveCam()
    {
        Vector3 camPos = transform.position;
        if (Input.mousePosition.x > screenWidth - MovementMarginWidth)
        {
            camPos.x += speed * Time.deltaTime;
        }
        if (Input.mousePosition.x < MovementMarginWidth)
        {
            camPos.x -= speed * Time.deltaTime;
        }
        if (Input.mousePosition.y > screenHeight - MovementMarginHeight)
        {
            camPos.z += speed * Time.deltaTime;
        }
        if (Input.mousePosition.y < MovementMarginHeight)
        {
            camPos.z -= speed * Time.deltaTime;
        }

        transform.position = camPos;
    }
}