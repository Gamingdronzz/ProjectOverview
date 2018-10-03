using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject CurrentGO = null;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        DetectCollisionWithBuilding();
    }

    private void DetectCollisionWithBuilding()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag.Equals(MyTagManager.Instance.Building))
                {
                    CurrentGO = hit.collider.gameObject;
                    Debug.Log("Building clicked " + CurrentGO.name + " Type = " + CurrentGO.GetComponent<Building>().buildingType.ToString());
                    CurrentGO.GetComponent<Building>().ShowBuildingProperties();
                }
            }
        }
    }
}