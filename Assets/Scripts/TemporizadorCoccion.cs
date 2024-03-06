using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemporizadorCoccion : MonoBehaviour
{
    public Slider sliderCoccion;
    public float duracionCoccion = 6f;
    private float tiempoRestante;
    private bool coccionEnCurso = false;

    [SerializeField]
    float x;
    [SerializeField]
    float y;

    public GameObject Food;
    public GameObject CookedTaco;
    public GameObject CookedArepa;
    public GameObject CookedNachos;
    public GameObject CookedOjo;
    public GameObject CookedGusano;

    void Start()
    {
        tiempoRestante = duracionCoccion;
        sliderCoccion.maxValue = duracionCoccion;
    }

    void Update()
    {
        if (coccionEnCurso && sliderCoccion.value < duracionCoccion)
        {
            tiempoRestante -= Time.deltaTime;
            sliderCoccion.value = duracionCoccion - tiempoRestante;

            if (tiempoRestante <= 0f)
            {
                // Cocción completa
                //Cambia animacion del sprite 
                if (Food.CompareTag("1000"))
                {
                    Instantiate(CookedTaco, new Vector3(x, y, 0f), transform.rotation);
                    Player.item = FoodID.PanTaco;
                    print(Player.item);
                }

                if (Food.CompareTag("2000"))
                {
                    Instantiate(CookedArepa, new Vector3(x, y, 0f), transform.rotation);
                    Player.item = FoodID.PanArepa;
                    print(Player.item);
                }

                if (Food.CompareTag("3000"))
                {
                    Instantiate(CookedNachos, new Vector3(x, y, 0f), transform.rotation);
                    Player.item = FoodID.PanNachos;
                    print(Player.item);
                }

                if (Food.CompareTag("0100"))
                {
                    Instantiate(CookedOjo, new Vector3(x, y, 0f), transform.rotation);
                    Player.item = FoodID.Ojo;
                }

                if (Food.CompareTag("0200"))
                {
                    Instantiate(CookedGusano, new Vector3(x, y, 0f), transform.rotation);
                    Player.item = FoodID.Gusanos;
                }

                //if (Food.CompareTag("0300"))
                //{
                //    Instantiate(CookedSponge, new Vector3(3.81f, -0.36f, 0f), transform.rotation);
                //    Player.item = FoodID.Gusanos;
                //}

                coccionEnCurso = false;
                Debug.Log("Cocción completa");
                ReiniciarTemporizador();
            }
        }
    }

    public void IniciarTemporizador()
    {
        //remove arrastrar?
        coccionEnCurso = true;
    }

    void ReiniciarTemporizador()
    {
        tiempoRestante = duracionCoccion;
        sliderCoccion.value = 0f;
        coccionEnCurso = false;
    }
}


