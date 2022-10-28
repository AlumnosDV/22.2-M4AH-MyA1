using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Car
{
    [SerializeField] Car_Model model;
    [SerializeField] Car_View view;
    [SerializeField] Car_Controller controller;
}
