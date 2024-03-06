using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoGusanoFusion : MonoBehaviour
{
    public GameObject NachoGusanoMocoPrefab;
    /*public GameObject NachoGusanoCeraPrefab;*/

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(NachoGusanoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoGusanosMoco;
            print(Player.item);
        }
        /*else if (other.gameObject.tag == "0020")
        {
            Instantiate(NachoGusanoCeraPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoGusanosCera;
            print(Player.item);
        }*/
    }
}
