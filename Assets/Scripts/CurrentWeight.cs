using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeight : MonoBehaviour
{
    public float weight;
    [SerializeField] private int i;
    [SerializeField] private GameLogic gameLogic;
    [SerializeField] private bool isChibi;

    private void Start()
    {
       if(!isChibi) weight = gameLogic.weightsListOther_P[i];
       if (isChibi) weight = gameLogic.weightsListChibs[i];
    }

}
