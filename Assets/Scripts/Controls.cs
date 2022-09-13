using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public void proceedToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
