using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public SpriteRenderer CharacterSR;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColorChanger(string ColorName)
    {
        switch (ColorName)
        {
            case "Red":
                CharacterSR.color = Color.red;
                break;
            case "Yellow":
                CharacterSR.color = Color.yellow;
                break;
            case "Blue":
                CharacterSR.color = Color.blue;
                break;
            case "Green":
                CharacterSR.color = Color.green;
                break;
            case "Black":
                CharacterSR.color = Color.black;
                break;
            case "Grey":
                CharacterSR.color = Color.grey;
                break;
        }
    }

}
