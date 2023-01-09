using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateCocktail : MonoBehaviour
{
    public CocktailsSO pickedSO;
    public int win;
    [SerializeField] private Text titleCocktail;
    [SerializeField] private Image imgCocktail;

    public GameObject textDai;
    public GameObject textKam;
    public GameObject textEsp;
    public GameObject  textPal;
    public GameObject textWhi;
    public GameObject textSpr;
    public GameObject textMar;

    string[] listCocktails = new string[] { "AperolSpritz", "Daiquiri", "EspressoMartini", "Kamikaze", "Margarita", "Paloma", "WhiteLady" };

    void Start()
    {
       //randCocktail();
       //compCocktail();
       //showresult();
    }
    public void randCocktail()
    {
        int rand = Random.Range(0, listCocktails.Length);
        Debug.Log("random :" + rand);
        pickedSO = Resources.Load("Cocktails/" + listCocktails[rand].ToString()) as CocktailsSO;
        titleCocktail.text = pickedSO.nameCocktail;
        imgCocktail.sprite = pickedSO.artwork;

        Debug.Log(rand);
        if(rand == 0)
            textSpr.SetActive(true);
        if(rand == 1)
            textDai.SetActive(true);
        if(rand == 2)
            textEsp.SetActive(true);
        if(rand == 3)
            textKam.SetActive(true);
        if (rand == 4)
            textMar.SetActive(true);
        if (rand == 5)
            textPal.SetActive(true);
        if (rand == 6)
            textWhi.SetActive(true);
    }

    public void compCocktail()
    {
        if (pickedSO.Ice!=IceType.None)
        {
            win = 0;
        }
        else if (pickedSO.Glass!=GlassType.ChilledMartini)
        {
            win = 0;
        }
        else
        {
            win = 1;
        }
        if (win == 0)
        {
            Debug.Log("You have failed");
        }
        else
        {
            
            Debug.Log("You have succeeded");
        }
    }


    /*public void Click()
    {
      Debug.Log( );
    }*/
}
