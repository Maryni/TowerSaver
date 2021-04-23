using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlace : MonoBehaviour
{
    [SerializeField] private bool isPlatformL;
    [SerializeField] private GameLogic gameLogic;
    [SerializeField] private CurrentWeight currentWeight;
    [SerializeField] private CorrectingWeight correctingWeight;
    [SerializeField] private PlatformController platformController;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Weight")
        {
            correctingWeight = other.gameObject.GetComponent<CorrectingWeight>();
            currentWeight = other.gameObject.GetComponent<CurrentWeight>();


            if (!isPlatformL) 
            { 
                gameLogic.SetPlatfWeight_R(currentWeight.weight); 
                platformController.SetRightText(currentWeight.weight); 
            }
            if (isPlatformL)
            {
                gameLogic.SetPlatfWeight_L(currentWeight.weight);
                correctingWeight.ClapToPlatform();
                platformController.SetLeftText(currentWeight.weight);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Weight")
        {
            correctingWeight = other.gameObject.GetComponent<CorrectingWeight>();
            currentWeight = other.gameObject.GetComponent<CurrentWeight>();


            if (!isPlatformL) 
            { 
                gameLogic.PlatformLoseWeight_R(currentWeight.weight); 
                platformController.SetRightText(currentWeight.weight); 
            }
            if (isPlatformL)
            {
                gameLogic.PlatformLoseWeight_L(currentWeight.weight);
                correctingWeight.ClapToPlatform();
                platformController.SetLeftText(currentWeight.weight);
            }
        }
    }
}
