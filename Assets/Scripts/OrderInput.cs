using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class OrderInput: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "1111" || other.gameObject.tag == "3111" || other.gameObject.tag == "1112" || other.gameObject.tag == "3112" || other.gameObject.tag == "1121" || other.gameObject.tag == "1122" || other.gameObject.tag == "1211" || other.gameObject.tag == "3211" || other.gameObject.tag == "1212" || other.gameObject.tag == "3212" || other.gameObject.tag == "1221" || other.gameObject.tag == "1222")
        {
            if (Player.item == ControladorDialogo.pedido)
            {
                ControladorDialogo.CORRECT = true;
            }
        }
        Destroy(other.gameObject);
    }
}
