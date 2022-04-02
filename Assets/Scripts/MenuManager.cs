using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text nameText;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
