using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankUser : MonoBehaviour
{
    [SerializeField] Client client;

    Dictionary<char, List<string>> names = new Dictionary<char, List<string>>();

    private void Start()
    {
        //string[] nombresEnteros = new string[500];

        //for (int i = 0; i < nombresEnteros.Length; i++)
        //{
        //    List<string> names = new List<string>();
        //    names.Add(nombresEnteros[i].ToCharArray(0,1)[0], names);
        //}
        //for (int i = 0; i < names['f'].Count; i++)
        //{

        //}

        //viene caminado

        var cachier = FindObjectOfType<Cashier>();

        cachier.GetMoney(15000, client);
    }
}


