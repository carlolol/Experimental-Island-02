using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void ShowGame ()
    {
        SceneManager.LoadScene(2);
    }


}
