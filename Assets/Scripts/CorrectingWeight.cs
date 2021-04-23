using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectingWeight : MonoBehaviour
{
    public void ClapToPlatform()
    {
        while (transform.position.y >= -1.85f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f);
        }
    }
     
}
