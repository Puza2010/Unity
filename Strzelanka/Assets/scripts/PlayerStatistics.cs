using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour
{
    int points;
    public static PlayerStatistics instance;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
        } else {
            instance = this;
        }
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
    }


}
