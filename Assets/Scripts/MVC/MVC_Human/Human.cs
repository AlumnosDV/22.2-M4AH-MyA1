using UnityEngine;

[System.Serializable]
public class Human
{
    [SerializeField] Human_Model model;
    [SerializeField] Human_View view;
    [SerializeField] Human_Controller controller;
}
