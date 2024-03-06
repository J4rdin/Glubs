using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoGusanoMocoFusion : MonoBehaviour
{
    public GameObject NachoGusanoMocoRoachPrefab;
    public GameObject NachoGusanoMocoUnasPrefab;



    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachoGusanoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoGusanosMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachoGusanoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoGusanosMocoUnas;
            print(Player.item);
        }
    }
}