using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Countdown");
    }

    private IEnumerator Countdown()
    { 
        yield return new WaitForSeconds (7);
        SceneManager.LoadScene (1);
    }
}