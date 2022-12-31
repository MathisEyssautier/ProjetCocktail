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
    public GlassType Glass;
    public IceType Ice;
    public MethodType methode;
}


[System.Serializable]
public class Garniture
{
    public GarnitureNature garnitureNature;
}

[System.Serializable]
public class Ingredient
{
    public int Quantity;
    public Nature IngredientsNature;
}


[System.Serializable]
public enum Nature
{
    LightRum,
    DarkRum,
    Vodka,
    Gin,
    Tequila,
    TripleSec,
    Prosecco,
    Aperol,
    OrangeJuice,
    GrapefruitJuice,
    CranJuice,
    LemonJuice,
    LimeJuice,
    Tonic,
    Espresso,
    CoffeeLiqueur,
    SugarSyrup,
    CremeDeMure,
    Sprite,
    SodaWater
}

[System.Serializable]
public enum GarnitureNature
{
    CoffeeBeans,
    LimeWedge,
    LemonWedge,
    LemonZest,
    GrapefruitSlice,
    OrangeSlice,
    SaltRim,
    None
}

[System.Serializable]
public enum GlassType
{
   Rocks,
   ChilledMartini,
   Highball,
   ChampagneFlute,
   WineGlass,
   Shooter
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
