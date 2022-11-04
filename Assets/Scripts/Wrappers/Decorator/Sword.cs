using UnityEngine;
public abstract class Sword
{
    //public Sword myDeco { get { return decorator; } }
    Sword decorator = null;
    int damage = 0;
    //string name = "";

    public Sword(Sword decorator, int damage /*, string name*/)
    {
        this.decorator = decorator;
        this.damage = damage;
    }

    public void Decorate(Sword decorator)
    {
        this.decorator = decorator;
    }

    public void TurnOn()
    {
        Debug.Log(this.ToString());
        OnTurnOn();
        decorator?.TurnOn();
    }
    protected abstract void OnTurnOn();
    public int GetDamage()
    {
        int aux = damage;
        if (decorator != null)
        {
            aux += decorator.GetDamage();
        }
        return aux;
    }
}
