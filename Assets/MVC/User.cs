using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    View_PlayerWalk view;
    Model_WalkPLayer model;
    Controller_WalkPlayer controller;

    private void Start()
    {

    }

    private void Update()
    {
        model.HorizontalMove(controller.Horizontal);
        model.VerticalMove(controller.Vertical);
    }
}
