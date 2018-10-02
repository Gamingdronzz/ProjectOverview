using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    // Use this for initialization
    public enum BuildingType
    {
        Hospital,
        School,
        Restaurant,
        Bar,
        Shop,
        Centre,
        Airport,
        Port
    }

    public BuildingType buildingType;
    public GameObject BillBoard;
    public Sprite BuildingIcon;
    private Image icon;

    private void Start()
    {
        this.tag = MyTagManager.Instance.Building;
        Instantiate(BillBoard, transform);
        icon = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        icon.sprite = BuildingIcon;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}