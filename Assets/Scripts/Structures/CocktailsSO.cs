using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cocktail", menuName = "Cocktail")]
public class CocktailsSO : ScriptableObject
{
    public string nameCocktail;
    public Sprite artwork;
    public List<Ingredient> ingredients;
    public List<Garniture> Garnish;
    public List<Methodes> Methode;
    public GlassType Glass;
    public IceType Ice;
}


[System.Serializable]
public class Garniture
{
    public int Qtt;
    public GarnitureNature garnitureNature;
}

[System.Serializable]
public class Ingredient
{
    public int Quantity;
    public Nature IngredientsNature;
}

[System.Serializable]
public class Methodes
{
    public MethodType Method;
}

[System.Serializable]
public enum Nature
{
    rum,
    vodka,
    gin,
    tequila,
    tripleSec,
    orangeJuice,
    cranjuice,
    tonic,
    espresso,
    coffeeLiqueur,
    sugarSyrup
}

[System.Serializable]
public enum GarnitureNature
{
    CoffeeBeans,
    LimeWedge,
    LemonWedge
}

[System.Serializable]
public enum GlassType
{
   Rocks,
   ChilledMartini,
   Highball
}

[System.Serializable]
public enum IceType
{
    None,
    Cubed,
    Crushed
}

[System.Serializable]
public enum MethodType
{
    Build,
    Shake,
    ShakeStrain,
    ShakeFineStrain
}
