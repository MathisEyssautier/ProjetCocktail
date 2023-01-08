using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCocktail : MonoBehaviour
{
    public CocktailsSO pickedSO;
    public int win;
    [SerializeField] private Text titleCocktail;
    [SerializeField] private Image imgCocktail;
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
