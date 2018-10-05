using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Building : MonoBehaviour
{
    private bool IsClicked = false;

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
    public TextMeshProUGUI txtBuildingType;
    private Image icon;

    private void Start()
    {
        this.tag = MyTagManager.Instance.Building;
        Instantiate(BillBoard, transform);
        icon = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        txtBuildingType = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        txtBuildingType.enabled = false;
        icon.sprite = BuildingIcon;
    }

    public void ShowBuildingProperties()
    {
        IsClicked = !IsClicked;
        txtBuildingType.text = buildingType.ToString();
        txtBuildingType.enabled = IsClicked;
    }
}