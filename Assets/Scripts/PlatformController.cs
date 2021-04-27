using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private Transform platformL;
    [SerializeField] private Transform platformR;
    [SerializeField] private RectTransform textL;
    [SerializeField] private RectTransform textR;
    [SerializeField] private Text textFieldL;
    [SerializeField] private Text textFieldR;
    [SerializeField] private List<BoxCollider> listWeightBC;

    private void MovePlatformUp(Transform platf)
    {
        while (platf.position.y <= 2.5f)
        {
            platf.position = new Vector3(platf.position.x, platf.position.y + 0.1f);

        }
    }
    private void MovePlatformDown(Transform platf)
    {
        while (platf.position.y >= -1.7f)
        {
            platf.position = new Vector3(platf.position.x, platf.position.y - 0.1f);
        }
    }

    public void MovePlatform_Up(int i)
    {
        if (i == 0)
        {
            MovePlatformUp(platformR);
            MoveRight(0);
            MovePlatformDown(platformL);
            MoveLeft(1);
        } else {
            MovePlatformUp(platformL);
            MoveLeft(0);
            MovePlatformDown(platformR);
            MoveRight(1);
        }
    }

    //0 = platformL | 1 = platformR


    /// <summary>
    /// 0 = up, 1 = down
    /// </summary>
    /// <param name="i"></param>
    private void MoveLeft(int i) //0 = up, 1 = down
    {
        if (i == 0)
        {
            // while (textL.transform.position.y <= 274f)
            // {
            textL.localPosition = new Vector2(textL.localPosition.x, 274);
            // }
        }
        if (i == 1)
        {
            // while (textL.transform.position.y >= -490f)
            // {
            textL.localPosition = new Vector2(textL.localPosition.x, -490);
            // }
        }

    }
    /// <summary>
    /// //0 = up, 1 = down
    /// </summary>
    /// <param name="i"></param>
    private void MoveRight(int i) //0 = up, 1 = down
    {
        if (i == 0)
        {

            textR.localPosition = new Vector2(textR.localPosition.x, 274);

        }
        if (i == 1)
        {
            // while (textR.transform.position.y >= -490f)
            // {
            textR.localPosition = new Vector2(textR.localPosition.x, -490);
            // }
        }
    }
    public void PlatformsHaveOneWeight()
    {
        platformL.position = new Vector3(platformL.position.x, 0.75f, platformL.position.z);
        platformR.position = new Vector3(platformR.position.x, 0.75f, platformR.position.z);
        textL.localPosition = new Vector2(textL.localPosition.x, -45);
        textR.localPosition = new Vector2(textR.localPosition.x, -45);
    }

    public void SetLeftText(float value) 
    { 
        textFieldL.text = (int.Parse(textFieldL.text) + value ).ToString(); 
        listWeightBC[0].enabled = false; 
        listWeightBC[1].enabled = false; 
        listWeightBC[2].enabled = false; 
        listWeightBC[3].enabled = false; 
    }
    public void SetRightText(float value) { textFieldR.text = (int.Parse(textFieldR.text) + value).ToString(); }

    //up 1.75 (to 2.5)
    //dowm  to -2.55

}
