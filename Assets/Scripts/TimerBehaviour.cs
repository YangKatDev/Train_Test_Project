using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerBehaviour : MonoBehaviour
{
    public float timeLeft = 30.0f;

    [SerializeField]
    int min, sec;

    [SerializeField]
    TextMeshProUGUI textBox;

    public static Action OnTimerEnds;

    void Update()
    {
        min = Mathf.FloorToInt(timeLeft / 60);
        sec = Mathf.FloorToInt(timeLeft % 60);

        timeLeft -= Time.deltaTime * 6;
        textBox.text = min.ToString("00") + ":" + sec.ToString("00");

        if (timeLeft <= 0)
        {
            OnTimerEnds?.Invoke();
            this.enabled = false;
        }
    }
}