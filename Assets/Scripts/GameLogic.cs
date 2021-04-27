using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] public List<float> weightsListChibs;
    [SerializeField] public List<float> weightsListOther_P;
    [SerializeField] private float platf_L;
    [SerializeField] private float platf_R;
    [SerializeField] private PlatformController platformController;
    [SerializeField] private AnimController animController;
 
    private void Awake()
    {
        SetWeight();
    }

    private void Update()
    {
        MovePlatform();
    }
    private void MovePlatform()
    {
        if(platf_L<platf_R)  //0 = platformL | 1 = platformR move UP
        {
            platformController.MovePlatform_Up(1);
            animController.SetMovingTrue();
        }
        if (platf_R < platf_L)
        {
            platformController.MovePlatform_Up(0);
            animController.SetMovingTrue();
        }
        if(platf_L==platf_R)
        {
            platformController.PlatformsHaveOneWeight();
            animController.SetMovingTrue();
        }
    }

    private void SetWeight()
    {
        for (int i = 0; i < weightsListChibs.Count; i++)
        {
            float temp = Random.Range(10, 100);
            temp = temp - (int)temp % 10;
            weightsListChibs[i] = temp;
        }  
    }

    public void SetPlatfWeight_L(float value) { platf_L = value; platformController.SetLeftText(platf_L); }
    public void SetPlatfWeight_R(float value) { platf_R = value; platformController.SetRightText(platf_R); }
    public void PlatformLoseWeight_L(float value) { platf_L -= value; }
    public void PlatformLoseWeight_R(float value) { platf_R -= value; }
}
