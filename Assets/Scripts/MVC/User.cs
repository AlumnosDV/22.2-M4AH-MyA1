using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class User : MonoBehaviour
{
    [SerializeField] Model model;
    [SerializeField] View view;
    [SerializeField] Controller controller;

    [SerializeField] Human human;
    [SerializeField] Car car;
    

    private void Start()
    {
        //Configuro Controllers
        human.Controller.Horizontal += WrapHorizontalInput;
        human.Controller.Vertical += WrapVerticalInput;
        human.Controller.HighProfile += WrapHighProfile;
        car.Controller.Horizontal += WrapHorizontalInput;
        car.Controller.Vertical += WrapVerticalInput;
        car.Controller.HighProfile += WrapHighProfile;

        //Seteo el primero de todo
        ChangeController(human.Controller);
        ChangeModel(human.Model);
        ChangeView(human.View);
    }
    public void WrapHighProfile(bool highProfile) 
    {
        model.HighProfileInput(highProfile);
        view.HighProfileInput(highProfile);
    }
    public void WrapHorizontalInput(float horizontal) 
    { 
        model.HorizontalInput(horizontal);
        view.HorizontalInput(horizontal);
    }
    public void WrapVerticalInput(float vertical) 
    { 
        model.VerticalInput(vertical);
        view.VerticalInput(vertical);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeModel(human.Model);
            ChangeView(human.View);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeModel(car.Model);
            ChangeView(car.View);
        }

        controller.FEED_Update(Time.deltaTime);
        model.FEED_Update(Time.deltaTime);
        view.FEED_Update(Time.deltaTime);

    }

    private void FixedUpdate()
    {
        if(controller != null) controller.FEED_FixedUpdate(Time.deltaTime);
        if(model != null) model.FEED_FixedUpdate(Time.deltaTime);
        if(view != null) view.FEED_FixedUpdate(Time.deltaTime);
    }

    void ChangeView(IActivable toActivate)
    {
        if (view != null)
        {
            IDeactivable toDeactivate = view;
            toDeactivate.Deactivate();
        }
        toActivate.Activate();
        view = (View)toActivate;
    }
    void ChangeModel(IActivable toActivate)
    {
        if (model != null)
        {
            IDeactivable toDeactivate = model;
            toDeactivate.Deactivate();
        }
        toActivate.Activate();
        model = (Model)toActivate;
    }
    void ChangeController(IActivable toActivate)
    {
        if (controller != null)
        {
            IDeactivable toDeactivate = controller;
            toDeactivate.Deactivate();
        }
        toActivate.Activate();
        controller = (Controller)toActivate;
    }

}


