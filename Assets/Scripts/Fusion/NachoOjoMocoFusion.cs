using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoOjoMocoFusion : MonoBehaviour
{
    public GameObject NachoOjoMocoRoachPrefab;
    public GameObject NachoOjoMocoUnasPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(NachoOjoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoOjoMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(NachoOjoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoOjoMocoUnas;
            print(Player.item);
        }

    }
}
