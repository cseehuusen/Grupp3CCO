using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    private static int kills, medicine,ammo,tp;

    public static int Kills
    {
        get
        {
            return kills;
        }
        set
        {
            kills = value;
        }
    }

    public static int Medicine
    {
        get
        {
            return medicine;
        }
        set
        {
            medicine = value;
        }
    }

    public static int Ammo
    {
        get
        {
            return ammo;
        }
        set
        {
            ammo = value;
        }
    }

    public static int TP
    {
        get
        {
            return tp;
        }
        set
        {
            tp = value;
        }
    }
}