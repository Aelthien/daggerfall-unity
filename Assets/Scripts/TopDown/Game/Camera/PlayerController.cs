using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float leftMouseHoldTime;
    public float cameraYawSpeed;
    public float cameraPitchSpeed;
    public float maxPitch;
    public float minPitch;

    public float cameraZoomSpeed;
    public float maxZoom;
    public float minZoom;
    public float defaultZoom;

    private GameObject springArm;

    // Use this for initialization
    void Start()
    {
        springArm = gameObject.transform.Find("SpringArm").gameObject;
        springArm.transform.localPosition = new Vector3(-defaultZoom, 0);
    }

    public void SetFacing(Vector3 vector, bool bSetCamera)
    {
        gameObject.transform.rotation = new Quaternion(0, vector.y, 0, 1);

        if (bSetCamera)
        {
            springArm.transform.rotation = new Quaternion(springArm.transform.rotation.x, vector.y, 0, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleMouseInput();
        UpdateCamera();
    }

    private void HandleMouseInput()
    {
        float startTime = 0;

        if (Input.GetButtonDown("LMB"))
            startTime = Time.time;

        if (Input.GetButtonUp("LMB"))
        {
            if (Time.time - startTime >= leftMouseHoldTime)
                LeftHold();
            else
                LeftClick();
        }
    }
    private void LeftClick()
    {

    }

    private void LeftHold()
    {

    }

    void UpdateCameraZoom()
    {
        float zoom = Input.GetAxis("CameraZoom");

        if (zoom != 0)
            springArm.transform.Translate(new Vector3(zoom * cameraZoomSpeed, 0, 0));
    }

    void UpdateCamera()
    {
        UpdateCameraYaw();
        UpdateCameraPitch();
        UpdateCameraZoom();
    }

    private void UpdateCameraYaw()
    {
        float yaw = Input.GetAxis("CameraYaw");

        if (yaw != 0)
            transform.RotateAround(transform.position, Vector3.up, yaw * cameraYawSpeed);
    }

    private void UpdateCameraPitch()
    {
        float pitch = Input.GetAxis("CameraPitch");

        if (pitch != 0)
            transform.RotateAround(transform.position, Vector3.right, pitch * cameraPitchSpeed);
    }
}