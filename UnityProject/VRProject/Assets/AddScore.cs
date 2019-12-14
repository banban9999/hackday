using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    private static int score = 0;
    private static int oldScore = 0;

    // Update is called once per frame
    void Update()
    {
        if (oldScore != score) {
            this.GetComponent<TextMesh>().text = score.ToString();
            oldScore = score;
        }
    }
    public static void addScore() {
        score++;
    }
}
