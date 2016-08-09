using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void ShowArea1 ()
    {
        SceneManager.LoadScene(2);
    }

    public void ShowArea2 ()
    {
        SceneManager.LoadScene(3);
    }

    public void ShowArea3 ()
    {
        SceneManager.LoadScene(4);
    }


}
