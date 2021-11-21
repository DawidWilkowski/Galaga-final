using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame = true;
    public Text livesText;
    public Text endScreen;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))// Esc wyrzuca do menu
        {
            SceneManager.LoadScene("Menu");
            lives = 3;
        }

        livesText.text = "Lives: " + lives;
        if(lives  == 0)
        {
            SceneManager.LoadScene("GameOver");
            lives = 3;
        }
        
    }
}
