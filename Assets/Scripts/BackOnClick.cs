using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackOnClick : MonoBehaviour
{

    public void SwitchScene()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
