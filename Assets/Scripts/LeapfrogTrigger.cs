using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapfrogTrigger : MonoBehaviour
{
    int enemyScore;

    public void OnTriggerEnter(Collider trig){
        if (trig.transform.CompareTag("Player")){
            bool p1 = GetComponentInParent<Move>().playerOne;
            string scoreplayer;
            if (p1) scoreplayer = "Player 2";
            else scoreplayer = "Player 1";

            enemyScore++;

            Debug.Log(scoreplayer + " scored! Their score is " + enemyScore);
            
        }
    }
}
