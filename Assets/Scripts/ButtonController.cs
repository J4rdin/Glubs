using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class ButtonController : MonoBehaviour
{
    string PlayerChoice;
    UnityEngine.UI.Text Uptext; 
    UnityEngine.UI.Text Downtext;
    UnityEngine.UI.Text Lefttext;
    UnityEngine.UI.Text Righttext;
    UnityEngine.UI.Text Entertext;

    public void ChangeControlUp()
    {
            PlayerChoice = Console.ReadLine();
            Player.Up = PlayerChoice;
            Uptext = GameObject.Find("Up").GetComponent<UnityEngine.UI.Text>();
            Uptext.text = PlayerChoice;
    }

    public void ChangeControlDown()
    {
        PlayerChoice = Console.ReadLine();
        Player.Down = PlayerChoice;
        Downtext = GameObject.Find("Down").GetComponent<UnityEngine.UI.Text>();
        Downtext.text = PlayerChoice;
    }

    public void ChangeControlRight()
    {
        PlayerChoice = Console.ReadLine();
        Player.Right = PlayerChoice;
        Righttext = GameObject.Find("Right").GetComponent<UnityEngine.UI.Text>();
        Righttext.text = PlayerChoice;
    }

    public void ChangeControlLeft()
    {
        PlayerChoice = Console.ReadLine();
        Player.Left = PlayerChoice;
        Lefttext = GameObject.Find("Left").GetComponent<UnityEngine.UI.Text>();
        Lefttext.text = PlayerChoice;
    }
    public void ChangeControlEnter()
    {
        PlayerChoice = Console.ReadLine();
        Player.Enter = PlayerChoice;
        Entertext = GameObject.Find("EnterScene").GetComponent<UnityEngine.UI.Text>();
        Entertext.text = PlayerChoice;
    }

    public void Playgame()
    {
        SceneManager.LoadScene("FoodTruckTopDown");
    }

    public void GoControls()
    {
        SceneManager.LoadScene("Controls", LoadSceneMode.Additive);
    }

    public void GoOptions()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Additive);
    }

    public void GoMenu()
    {
        WorkStation.entered = false;
        SceneManager.LoadScene("Menu");
    }

    public void GoBackControls()
    {
        SceneManager.UnloadSceneAsync("Controls");
    }

    public void GoBackOptions()
    {
        SceneManager.UnloadSceneAsync("Options");
    }

    public void GoBackPause()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void GoBackMeat()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Meat");
        if(Player.item != "0000")
            DestroyFood();
    }
    public void GoBackBread()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Bread");
        if (Player.item != "0000")
            DestroyFood();
    }

    public void GoBackClients()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Clientes");
        Player.item = "0000";
    }

    public void GoBackToppings()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        if (Player.item != "0000")
            DestroyFood();
    }
    public void DestroyFood()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(Player.item);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
