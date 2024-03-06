using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapePlayer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            WorkStation.entered = true;
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        }
    }
}
