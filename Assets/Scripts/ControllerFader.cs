using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControllerFader : MonoBehaviour
{
    public GameObject controller;

    public void createIcon(Vector2 touchPos)
    {
        controller.GetComponent<Image>().enabled = true;
        controller.transform.position = new Vector3(touchPos.x, touchPos.y, 0);
        controller.GetComponent<Joystick>().UpdatePosition(controller.transform.position);
    }

    public void destroyIcon()
    {
        controller.GetComponent<Image>().enabled = false;
    }
}
