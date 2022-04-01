using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static TextMeshProUGUI nameText;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
