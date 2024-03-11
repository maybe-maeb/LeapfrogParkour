using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public enum GameStates{Start, InPlay, Win};
    public GameStates state;
    public TextMeshProUGUI winScreen;

    public void Start(){
        winScreen.text = "";
        state = GameStates.Start;
    }

    public void Win(bool p1){
        if (p1) winScreen.text = "Player two wins!";
        else winScreen.text = "Player one wins!";

        state = GameStates.Win;
    }
}