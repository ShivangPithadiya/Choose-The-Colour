using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManagerrr : MonoBehaviour
{
    public Camera mainCamara;
   
    void Update()
    {
        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        Vector3 mouseTowardsWorld = mainCamara.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosBlock =mouseTowardsWorld;
        paddlePos.x = mousePosBlock.x;
        paddlePos.x = Mathf.Clamp(mousePosBlock.x, -2f, 2f);
        this.transform.position = paddlePos;
    }
   
}
