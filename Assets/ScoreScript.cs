using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scorePoint;
    public int score;

    [ContextMenu("Increase Score")]
    public void addScorePoint()
    {
        score += 1;
        scorePoint.text = score.ToString();
    }
}
