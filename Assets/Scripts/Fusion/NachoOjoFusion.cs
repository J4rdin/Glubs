using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoOjoFusion : MonoBehaviour
{
    public GameObject NachoOjoMocoPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "0010")
        {
            Instantiate(NachoOjoMocoPrefab, new Vector3(1f, -3f, 0f), transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Player.item = FoodID.NachoOjoMoco;
            print(Player.item);
        }
    }

}
