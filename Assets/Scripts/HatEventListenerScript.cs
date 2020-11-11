using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatEventListenerScript : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void HatChanger(int HatIndex)
    {
        PlayerPrefs.SetInt("HatSaver", HatIndex);
    }
}
