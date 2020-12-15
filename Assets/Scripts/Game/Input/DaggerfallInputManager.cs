using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DaggerfallWorkshop.Game;
using UnityEngine.InputSystem;
using DaggerfallWorkshop.Game.UserInterfaceWindows;
using System;
using DaggerfallWorkshop.Game.UserInterface;

public class DaggerfallInputManager : InputManager
{

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        Setup();
        BindInputs();
    }

    void Update()
    {
        /// if (DaggerfallUI.UIManager.TopWindow != null)
           //  DaggerfallUI.UIManager.TopWindow.HandleHover();
    }

    protected void Setup()
    {
        Debug.Log("Setting up controls");
        controls = new DaggerfallControls();
    }

    protected void BindInputs()
    {
        Debug.Log("Binding input functions");

        controls.KeyboardMouse.Fire.performed += context => OnFire();
        controls.KeyboardMouse.Inventory.performed += context => OnInventory();
        controls.KeyboardMouse.Cancel.performed += context => OnCancel();
        controls.KeyboardMouse.Transport.performed += context => OnTransport();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    #region Input Bindings

    private void OnFire()
    {
        Mouse mouse = Mouse.current;
        Camera camera = Camera.main;
        if (mouse.position.x.ReadValue() >= camera.pixelWidth
            || mouse.position.x.ReadValue() <= 0
            || mouse.position.y.ReadValue() >= camera.pixelHeight
            || mouse.position.y.ReadValue() <= 0)
            return;

        DaggerfallUI.UIManager.TopWindow.HandleMouseClick(CurrentMousePosition);
    }

    private void OnJump()
    {

    }

    private void OnCancel()
    {
        DaggerfallUI.UIManager.CloseWindow();
    }

    private void OnSubmit()
    {

    }

    private void OnAim(InputAction.CallbackContext context)
    {

    }

    private void OnMovement(InputAction.CallbackContext context)
    {

    }

    private void OnTravelMapList()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTransportWindow)
        {

        }
    }

    private void OnTravelMapFind()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTravelMapWindow)
        {
            DaggerfallTravelMapWindow window = (DaggerfallTravelMapWindow)DaggerfallUI.UIManager.TopWindow;
            window.FindLocation();
        }
    }

    private void OnTransport()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTransportWindow)
            DaggerfallUI.UIManager.CloseWindow();
        else
            DaggerfallUI.PostMessage(DaggerfallUIMessages.dfuiOpenTransportWindow);
    }

    private void OnTransportFoot()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTransportWindow)
        {
            DaggerfallTransportWindow window = (DaggerfallTransportWindow)DaggerfallUI.UIManager.TopWindow;
            window.SelectFootMode();
        }
    }

    private void OnTransportHorse()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTransportWindow)
        {
            DaggerfallTransportWindow window = (DaggerfallTransportWindow)DaggerfallUI.UIManager.TopWindow;
            window.SelectHorseMode();
        }
    }

    private void OnTransportCart()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTransportWindow)
        {
            DaggerfallTransportWindow window = (DaggerfallTransportWindow)DaggerfallUI.UIManager.TopWindow;
            window.SelectShipMode();
        }
    }

    private void OnTransportShip()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallTransportWindow)
        {
            DaggerfallTransportWindow window = (DaggerfallTransportWindow)DaggerfallUI.UIManager.TopWindow;
            window.SelectShipMode();
        }
    }

    private void OnInventory()
    {
        if (DaggerfallUI.UIManager.TopWindow is DaggerfallInventoryWindow)
            DaggerfallUI.UIManager.CloseWindow();
        else
            DaggerfallUI.PostMessage(DaggerfallUIMessages.dfuiOpenInventoryWindow);
    }

    #endregion
}
