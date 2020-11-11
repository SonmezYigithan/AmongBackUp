using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionScript : MonoBehaviour
{
    public GameObject PanelShop;

    void Start()
    {
        PanelShop.SetActive(false);
    }


    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Laptop")
        {
            PanelShop.SetActive(true);
        }
    }
}
