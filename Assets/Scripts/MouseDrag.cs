using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    [SerializeField] private bool needToChangeZ;
    [SerializeField] private float mZCoordFromInspector; 
    private Vector3 mOffset;

    private float mZCoord;
    private void OnMouseDown()
    {
        if(!needToChangeZ)mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        if (needToChangeZ && mZCoordFromInspector != 0) mZCoord = mZCoordFromInspector;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
