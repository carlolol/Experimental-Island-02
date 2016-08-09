using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CheckNext : MonoBehaviour
{
    Transform mainCamTransform; //Stores the FPS camera transform
    public float distanceToAppear = 2;
    public GameObject next;

    void Start()
    {
        mainCamTransform = Camera.main.transform;//Get camera transform reference
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(mainCamTransform.position, transform.position);

        //We have reached the distance to Enable Object
        if (distance < distanceToAppear)
            next.SetActive(true);
        else
            next.SetActive(false);
    }

}
