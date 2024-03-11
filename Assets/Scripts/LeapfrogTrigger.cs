/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapfrogTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;
    int enemyScore;

    public void OnTriggerEnter(Collider trig)
    {
        if (trig.transform.CompareTag("Player"))
        {
            bool p1 = GetComponentInParent<Move>().playerOne;

            scoreManager.Score(p1);

            if (trig.transform.GetComponent<Inventory>().isPowered) scoreManager.Win(p1);
        }
    }
}
*/