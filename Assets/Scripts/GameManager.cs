using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject UI, Level1, Level2, Level3, Level3a, Level3b, Level4, Level4a, Level4b, Level5, Level5a, GameOverScreen, TitleScreen, Ending1, Ending2;
    public int healthValue, staminaValue;
    public TextMeshProUGUI healthText, staminaText;

    // Start is called before the first frame update
    void Start()
    {
        TitleScreen.SetActive(true);
        UI.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(false);
        Level3a.SetActive(false);
        Level3b.SetActive(false);
        Level4.SetActive(false);
        Level4a.SetActive(false);
        Level4b.SetActive(false);
        Level5.SetActive(false);
        Level5a.SetActive(false);
        Ending1.SetActive(false);
        Ending2.SetActive(false);   
        GameOverScreen.SetActive(false);
        healthValue = 10;
        staminaValue = 10;
    }

    public void StartGameButton()
    {
        TitleScreen.SetActive(false);
        Level1.SetActive(true);
        UI.SetActive(false);
        Level2.SetActive(false);
        Ending1.SetActive(false);
        Ending2.SetActive(false);
        Level4a.SetActive(false);
        Level4b.SetActive(false);
        GameOverScreen.SetActive(false);
        healthValue = 10;
        staminaValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = healthValue.ToString();
        staminaText.text = staminaValue.ToString();
    }

    public void wantsToBetaTest()
    {
        UI.SetActive(true);
        Level2.SetActive(true);
        Level1.SetActive(false);
        Ending1.SetActive(false);
    }

    public void continueForward()
    {
        UI.SetActive(true);
        Level3.SetActive(true);
        Level2.SetActive(false);

    }

    public void collect()
    {
        UI.SetActive(true);
        Level3a.SetActive(true);
        Level3.SetActive(false);
        staminaValue = Random.Range(4, 9);
    }

    public void dontCollect()
    {
        UI.SetActive(true);
        Level3b.SetActive(true);
        Level3a.SetActive(false);
        Level3.SetActive(false);
        Ending2.SetActive(false) ;
    }

    public void Continue()
    {
        UI.SetActive(true);
        Level4.SetActive(true);
        Level3a.SetActive(false);
        Level3b.SetActive(false);
    }

    //ENDING 3
    public void aggressive()
    {
        Level4.SetActive(false);
        Level4a.SetActive(true);   
        healthValue = 0;
        staminaValue = 0;
    }

    public void sneak()
    {
        Level4.SetActive(false);
        Level4b.SetActive(true);
    }

    public void fight()
    {
        Level4a.SetActive(false);
        Level5a.SetActive(true);
        healthValue = Random.Range(1,10);
        staminaValue -= Random.Range (1,3);
    }

    public void dontFight()
    {
        Level4a.SetActive(false);
        Level5.SetActive(true);
        healthValue = 0;
        staminaValue = 0;
    }

    public void gameOverScreen()
    {
        Level5a.SetActive(false);
        GameOverScreen.SetActive(true);
        UI.SetActive(false);
    }

    //ENDING 2
    public void goBack()
    {
        Level2.SetActive(false);
        Ending2.SetActive(true);
        UI.SetActive(false);
    }
    //ENDING 1
    public void doesNotWantToBetaTest()
    {
        Level1.SetActive(false);
        Level2.SetActive(false);
        Ending1.SetActive(true);
    }

    public void exitButton()
    {
        Application.Quit();
    }
}
