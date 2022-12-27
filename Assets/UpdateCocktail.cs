using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCocktail : MonoBehaviour
{
    public CocktailsSO pickedSO;
    [SerializeField] private Text titleCocktail;
    [SerializeField] private Image imgCocktail;
    string[] listCocktails = new string[] { "AperolSpritz", "Daiquiri", "EspressoMartini", "Kamikaze", "Margarita", "Paloma", "WhiteLady" };

    void Start()
    {
        randCocktail();
    }
    public void randCocktail()
    {
        int rand = Random.Range(0, listCocktails.Length);
        Debug.Log("random :" + rand);
        pickedSO = Resources.Load("Cocktails/" + listCocktails[rand].ToString()) as CocktailsSO;
        titleCocktail.text = pickedSO.nameCocktail;
        imgCocktail.sprite = pickedSO.artwork;

    }

    /*public void Click()
    {
      Debug.Log( );
    }*/
}
