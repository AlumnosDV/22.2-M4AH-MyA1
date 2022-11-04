using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sword 
{
    Sword composition;
    int damage = 20;
    public Sword(Sword sword, int damage = 20)
    {
        composition = sword;
        this.damage = damage;
    }

    public void Execute()///fire, hielo, toxic
    {
        OnExecute();//fire execute, hielo execute,, toxic execute

        if (composition != null) composition.Execute(); //hielo, toxic, null
    }



    public int GetDamage()
    {
        int aux = damage;
        if (composition != null) aux += composition.GetDamage();
        return aux;
    }

    protected abstract void OnExecute();
}
