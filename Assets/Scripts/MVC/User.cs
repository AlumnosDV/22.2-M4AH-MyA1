using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    [SerializeField] Model model;
    [SerializeField] View view;
    [SerializeField] Controller controller;

    [SerializeField] Human human;
    [SerializeField] Car car;

    bool isHuman = true;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Change()
    {
        isHuman = !isHuman;

        if (isHuman)
        {
            model = 
        }
    }

}
