using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public enum GameStates{Start, InPlay, Win};
    public GameStates state;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI winScreen;

    public int p1Score;
    public int p2Score;

    public void Start(){
        winScreen.text = "";
        state = GameStates.Start;
    }

    public void Score(bool p1){
        if (p1) p2Score++;
        else p1Score++;

        p1ScoreText.text = "Player One Score: " + p1Score;
        p2ScoreText.text = "Player Two Score: " + p2Score;

        if (p1Score > 3 || p2Score > 3)
        {
             Win(p1);
        }
    }

    public void Win(bool p1){
        if (p1) winScreen.text = "Player two wins!";
        else winScreen.text = "Player one wins!";

        state = GameStates.Win;
    }
}