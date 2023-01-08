using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CManager : MonoBehaviour
{

    public Dropdown DropGlass;
    public Dropdown DropIce;
    public Dropdown DropMethod;
    public Dropdown DropGar;
    public Slider SlidLightRum;
    public Slider SlidVodka;
    public Slider SlidTequila;
    public Slider SlidTripleSec;
    public Slider SlidProsecco;
    public Slider SlidAperol;
    public Slider SlidGrapefruitJuice;
    public Slider SlidLemonJuice;
    public Slider SlidLimeJuice;
    public Slider SlidEspresso;
    public Slider SlidCoffeeLiqueur;
    public Slider SlidSugarSyrup;
    public Slider SlidSodaWater;
    public CocktailsSO pickedSO;
    public int win;

    public GameObject chartoanim;
    Animator animator;
    public GameObject cam;
    Animator animCam;

    public GameObject pannelDisplay;
    public GameObject textRate;
    public GameObject textReussi;

    [SerializeField] private Text titleCocktail;
    [SerializeField] private Image imgCocktail;
    string[] listCocktails = new string[] { "AperolSpritz", "Daiquiri", "EspressoMartini", "Kamikaze", "Margarita", "Paloma", "WhiteLady" };

    // Start is called before the first frame update

    void Start()
    {
        animator = chartoanim.GetComponent<Animator>();
        animCam = cam.GetComponent<Animator>();
    }

    

    public void randCocktail()
    {
        int rand = Random.Range(0, listCocktails.Length);
        //Debug.Log("random :" + rand);
        pickedSO = Resources.Load("Cocktails/" + listCocktails[rand].ToString()) as CocktailsSO;
        titleCocktail.text = pickedSO.nameCocktail;
        imgCocktail.sprite = pickedSO.artwork;

    }

    public void compCocktail()
    {
/*      Debug.Log(DropGlass.options[DropGlass.value].text);
        Debug.Log(pickedSO.Glass.ToString());
        Debug.Log(DropIce.options[DropIce.value].text);
        Debug.Log(pickedSO.Ice.ToString());
        Debug.Log(DropMethod.options[DropMethod.value].text);
        Debug.Log(pickedSO.methode.ToString());
        Debug.Log(SlidLightRum.value);
        Debug.Log(pickedSO.ingredients[0].Quantity);
        Debug.Log(SlidVodka.value);
        Debug.Log(pickedSO.ingredients[1].Quantity);
        Debug.Log(DropGar.options[DropGar.value].text);
        Debug.Log(pickedSO.Garnish[0].garnitureNature.ToString()); */
        if (pickedSO.Ice.ToString() != DropIce.options[DropIce.value].text)
        {
            win = 0;
        }
        else if (pickedSO.Glass.ToString() != DropGlass.options[DropGlass.value].text)
        {
            win = 0;
        }
        else if (pickedSO.methode.ToString() != DropMethod.options[DropMethod.value].text)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[0].Quantity != SlidLightRum.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[1].Quantity != SlidVodka.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[2].Quantity != SlidTequila.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[3].Quantity != SlidTripleSec.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[4].Quantity != SlidProsecco.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[5].Quantity != SlidAperol.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[6].Quantity != SlidGrapefruitJuice.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[7].Quantity != SlidLemonJuice.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[8].Quantity != SlidLimeJuice.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[9].Quantity != SlidEspresso.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[10].Quantity != SlidCoffeeLiqueur.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[11].Quantity != SlidSugarSyrup.value)
        {
            win = 0;
        }
        else if (pickedSO.ingredients[12].Quantity != SlidSodaWater.value)
        {
            win = 0;
        }
        else if (pickedSO.Garnish[0].garnitureNature.ToString() != DropGar.options[DropGar.value].text)
        {
            win = 0;
        }
        else
        {
            win = 1;
        }
        if (win == 0)
        {
            animator.SetBool("NoLikes", true);
            animCam.SetBool("Zoom", true);
            pannelDisplay.SetActive(false);
            textRate.SetActive(true);
            Debug.Log("You have failed");
        }
        else
        {
            animator.SetBool("Likes", true);
            animCam.SetBool("Zoom", true);
            pannelDisplay.SetActive(false);
            textReussi.SetActive(true);
            Debug.Log("You have succeeded");
        }
    }

}
