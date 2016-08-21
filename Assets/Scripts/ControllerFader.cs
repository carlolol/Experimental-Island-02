using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ControllerFader : MonoBehaviour
{
    public GameObject controller;

    public void createIcon(Vector2 touchPos)
    {
        controller.SetActive(true);
        controller.transform.position = new Vector3(touchPos.x, touchPos.y, 0);
        controller.GetComponent<Joystick>().CreateVirtualAxes();
    }

    public void destroyIcon()
    {
        controller.SetActive(false);
    }
}
