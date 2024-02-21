using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeapfrogTrigger : MonoBehaviour
{
    public TextMeshProUGUI otherPlayerScore;
    public TextMeshProUGUI winScreen;
    int enemyScore;

    void Start(){
        winScreen.text = "";
    }    

    public void OnTriggerEnter(Collider trig){
        if (trig.transform.CompareTag("Player")){
            bool p1 = GetComponentInParent<Move>().playerOne;
            string scoreplayer;
            if (p1) scoreplayer = "Player 2";
            else scoreplayer = "Player 1";

            enemyScore++;

            if (p1) otherPlayerScore.text = "Player Two Score: " + enemyScore;
            else otherPlayerScore.text = "Player One Score: " + enemyScore;

            if (enemyScore > 3) {
                if (p1) winScreen.text = "Player two wins!";
                else winScreen.text = "Player one wins!";
            }

            Debug.Log(scoreplayer + " scored! Their score is " + enemyScore);
            
        }
    }
}
