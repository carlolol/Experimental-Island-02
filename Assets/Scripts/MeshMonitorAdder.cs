using UnityEngine;
using System.Collections;

public class MeshMonitorAdder : MonoBehaviour
{
    private GameObject[] things;

	void Start ()
    {
        things = GameObject.FindGameObjectsWithTag("Objects");
        foreach(GameObject thing in things)
        {
            thing.AddComponent<MeshMonitor>();
        }
	}

}
