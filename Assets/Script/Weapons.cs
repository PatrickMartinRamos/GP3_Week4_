using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    int damage_Pistol = 10;
    int damage_AK47 = 8;
    //syntax of a property: Acces Modifier, Type, Name of the Property
    //Rule is that the property is the same name as the field variable
    //After the property create a braces, like a function, inside it is where we
    //put our property accessors
    //A property can have 2 accessor: "get" and "set"
public int Damage_Pistol
    {
        get { return damage_Pistol; }
        set { damage_Pistol = value; }
    }
    public int Damage_AK47
    {
        get { return damage_AK47; }
        set { damage_AK47 = value; }
    }
}
public class DamagePowerUp
{
    //Percentage Values
    float concentration = 10f;
    public float Concentration
    {
        get { return concentration; }
        set { concentration = value; }
    }
    //Base Values
    int focus = 20;
    public int Focus
    {
        get { return focus; }
        set { focus = value; }
    }
}
public class RangePowerUp
{
}
public class SpeedPowerUp
{
}

