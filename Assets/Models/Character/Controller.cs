using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("click");
            anim.SetBool("attack", true);
        }
        else if(Input.GetMouseButtonUp(0))
            anim.SetBool("attack", false);
	}
}
