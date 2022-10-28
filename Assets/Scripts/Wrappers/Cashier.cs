using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cashier : MonoBehaviour
{
    [SerializeField] BankData data;
    [SerializeField] Bank bank;

    public int GetMoney(int quant, Client client)
    {
        if (data.Clients.Contains(client))
        {
            if (quant <= client.Money)
            {
                return bank.GetMoney(quant);
            }
        }

        return 0;
    }
}

[System.Serializable]
public class BankData
{
    [SerializeField] Bank bank;
   
    [SerializeField] List<Client> clientes = new List<Client>();
    public List<Client> Clients => clientes;
}
[System.Serializable]
public class Client
{
    [SerializeField] string name;
    [SerializeField] string DNI;
    [SerializeField] int money; //lop que tengo en el banco
    public int Money => money;
    public string Name => name;
}
