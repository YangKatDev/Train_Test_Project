using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddsTimeBehaviour : MonoBehaviour
{

    [SerializeField]
    TimerBehaviour timerBehaviour;

    private void OnEnable()
    {
        TrainMovementBehaviour.OnAddsTime += AddsTime;
    }

    private void OnDisable()
    {
        TrainMovementBehaviour.OnAddsTime -= AddsTime;
    }

    void AddsTime()
    {
        timerBehaviour.timeLeft += 12f;
    }
}
