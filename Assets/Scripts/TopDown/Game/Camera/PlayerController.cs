using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DaggerfallWorkshop.Game;

public class PlayerController : MonoBehaviour
{
    public float interactHoldTime;
    private double interactStartTime;

    public float cameraYawSpeed;
    public float cameraPitchSpeed;
    public float maxPitch;
    public float minPitch;

    public float cameraZoomSpeed;
    public float maxZoom;
    public float minZoom;
    public float defaultZoom;

    private GameObject springArm;

    private InputAction interact;
    private GameInputs inputs;

    void Awake()
    {
        inputs = new GameInputs();

        inputs.Game.Interact.performed += context => OnInteract(context);

        //User interface bindings
        inputs.Game.Inventory.performed += context => ToggleUI("inventory");
        inputs.Game.Character.performed += context => ToggleUI("character");
        inputs.Game.Skills.performed += context => ToggleUI("skills");
        inputs.Game.Menu.performed += context => ToggleUI("menu");
        inputs.Game.MapTravel.performed += context => ToggleUI("mapTravel");
    }

    void ToggleUI(string name)
    {
        DaggerfallUI.UIManager.ToggleWindow(name);
    }

    /*void Start()
    {
        springArm = gameObject.transform.Find("SpringArm").gameObject;
        springArm.transform.localPosition = new Vector3(-defaultZoom, 0);
    }*/

    private void OnEnable()
    {
        inputs.Enable();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }

    public void SetFacing(float x, float y, bool bSetCamera)
    {
        SetFacing(new Vector3(x, y, 0), bSetCamera);
    }

    public void SetFacing(Vector3 vector, bool bSetCamera)
    {
        gameObject.transform.rotation = new Quaternion(0, vector.y, 0, 1);

        if (bSetCamera)
        {
            //springArm.transform.rotation = new Quaternion(springArm.transform.rotation.x, vector.y, 0, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCamera();
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        if (context.duration >= interactHoldTime)
            holdInteraction();
        else
            quickInteraction();
    }

    private void quickInteraction()
    {
        Debug.Log("Quick");
    }

    private void holdInteraction()
    {
        Debug.Log("Hold");
    }

    void UpdateCameraZoom()
    {/*
        float zoom = Input.GetAxis("CameraZoom");

        if (zoom != 0)
            springArm.transform.Translate(new Vector3(zoom * cameraZoomSpeed, 0, 0));*/
    }

    void UpdateCamera()
    {
        UpdateCameraYaw();
        UpdateCameraPitch();
        UpdateCameraZoom();
    }

    private void UpdateCameraYaw()
    {/*
        float yaw = Input.GetAxis("CameraYaw");

        if (yaw != 0)
            transform.RotateAround(transform.position, Vector3.up, yaw * cameraYawSpeed);*/
    }

    private void UpdateCameraPitch()
    {/*
        float pitch = Input.GetAxis("CameraPitch");

        if (pitch != 0)
            transform.RotateAround(transform.position, Vector3.right, pitch * cameraPitchSpeed);*/
    }
}