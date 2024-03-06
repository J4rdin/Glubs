using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GusanoFusion : MonoBehaviour
{
    public GameObject TacoGusanosPrefab;
    public GameObject NachoGusanosPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "1000")
        {
            Instantiate(TacoGusanosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.TacoGusanos;
            print(Player.item);
        }
        else if (other.gameObject.tag == "3000")
        {
            Instantiate(NachoGusanosPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoGusanos;
            print(Player.item);
        }
    }
}
