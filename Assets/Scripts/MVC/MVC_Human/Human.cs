using UnityEngine;
[System.Serializable]
public class Human
{
    [SerializeField] Human_Model model;
    [SerializeField] Human_View view;
    [SerializeField] Human_Controller controller;
    public Human_Model Model { get { return model; } }
    public Human_View View { get { return view; } }
    public Human_Controller Controller { get { return controller; } }
}
