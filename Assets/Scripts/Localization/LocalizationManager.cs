using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager instance;
    private void Awake() => instance = this;

    //Database Dictionary< KEY_LENGUAJE , Dictionary <KEY_INTERNA , VAl_TRADUCIDO> >
    Dictionary<string, Dictionary<string, string>> database = new Dictionary<string, Dictionary<string, string>>();

    const string ARG = "es-AR";
    const string US = "en-US";

    string currentlang = "";

    private void Start()
    {
        database.Add(ARG,new Dictionary<string, string>());
        database.Add(US, new Dictionary<string, string>());

        currentlang = US;

        StreamLanguage(currentlang);
       
    }

    public void StreamLanguage(string lang)
    {
        currentlang = lang;
        LoadText();
    }

    #region Cambio de Idioma
    // ESTO ESTA MUY FEO, USTEDES LO HACEN BIEN
    bool swichtlang = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            swichtlang = !swichtlang;
            StreamLanguage(swichtlang ? US: ARG);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(GetText("door"));
        }
    }
    #endregion

    public string GetText(string key)
    {
        return database[currentlang][key];
    }

    public void LoadText()
    {
        //esto me devuelve todo el documento entero
        string text = TextLoad.ReadText(currentlang);

        //aca empieza el tratamiento

        //separo entre COLUMNAS "ENTERS (\n)"
        string[] rows = text.Split('\n');

        //recorrer todas las columnasd
        for (int i = 0; i < rows.Length; i++)
        {

            //separamos entre COMAS ","
            string[] keyval = rows[i].Split(',');

            //obtengo el KEY
            string code = keyval[0];

            //obtengo el Value
            string val = keyval[1];

            //si yo no tenia esa key
            if (!database[currentlang].ContainsKey(code))
            {
                //en ese lenguaje, en esa key, ese valor
                database[currentlang].Add(code, val);
            }
            else
            {
                //pasa por aca si ya tenia ese key, entonces la actualiza
                database[currentlang][code] = val;
            }
        }
    }
}
