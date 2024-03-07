using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshPro text;

    public void SetScore(int value)
    {
        text.text = value.ToString();
    }
}
