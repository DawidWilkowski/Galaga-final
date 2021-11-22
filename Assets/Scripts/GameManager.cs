using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;    //3 życia
    public static bool playGame = true;
    public Text livesText;  //box z textem o życiach
    public Text endScreen;  //box napisy końcowe/END
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;   //info nt. żyć
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
        if(lives  == 0)
        {
            endScreen.text = "GAME OVER";   // :-(
        }

    }
}
