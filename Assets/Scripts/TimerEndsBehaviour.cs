using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerEndsBehaviour : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI loseText;

    private void OnEnable()
    {
        TimerBehaviour.OnTimerEnds += DisplayLoseText;
    }

    private void OnDisable()
    {
        TimerBehaviour.OnTimerEnds -= DisplayLoseText;
    }

    void DisplayLoseText()
    {
        loseText.enabled = true;
    }
}