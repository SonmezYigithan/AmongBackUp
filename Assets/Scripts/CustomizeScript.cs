using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeScript : MonoBehaviour
{
    private Image PlayerImage;
    public Color[] Colors;
    void Start()
    {
        //ShowHats();
        PlayerImage = GetComponent<Image>();
        PlayerPrefs.SetInt("ColorSaver", 7);
    }

    void Update()
    {
        PlayerColorChanger(PlayerPrefs.GetInt("ColorSaver"));
        ShowHats(PlayerPrefs.GetInt("HatSaver"));
    }

    private void ShowHats(int HatIndex)
    {
        foreach (Transform child in transform)
        {
            child.transform.gameObject.SetActive(false);
        }
        transform.GetChild(HatIndex).gameObject.SetActive(true);
    }

    private void PlayerColorChanger(int ColorIndex)
    {
        switch (ColorIndex)
        {
            case 0:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 1:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 2:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 3:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 4:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 5:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 6:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 7:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 8:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 9:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 10:
                PlayerImage.color = Colors[ColorIndex];
                break;
            case 11:
                PlayerImage.color = Colors[ColorIndex];
                break;
        }
    }
}
