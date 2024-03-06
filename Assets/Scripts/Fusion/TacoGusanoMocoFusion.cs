using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoGusanoMocoFusion : MonoBehaviour
{
    public GameObject TacoGusanoMocoRoachPrefab;
    public GameObject TacoGusanoMocoUnasPrefab;

    // Create gameobject for fusion: ex -> public GameObject TacoGusanoMocoHairPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0001")
        {
            Instantiate(TacoGusanoMocoRoachPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanosMocoRoach;
            print(Player.item);
        }
        else if (other.gameObject.tag == "0002")
        {
            Instantiate(TacoGusanoMocoUnasPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanosMocoUnas;
            print(Player.item);
        }
        //Create script that detects collision, destroys both objects and instantiates their fusion. It must also set the players item to food id.
        //Ex->
        //else if (other.gameObject.tag == "0003")
        //{
        //    Instantiate(TacoGusanoMocoHairPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
        //    Destroy(other.gameObject);
        //    Destroy(gameObject);
        //    Player.item = FoodID.TacoGusanosMocoHair;
        //    print(Player.item);
        //}
    }
}
