using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*************************************************************
 *   ---------------Camera FLow implement--------------------
 *************************************************************/
// Ref : https://blog.csdn.net/qq_14942529/article/details/82584702

public class CameraFlow : MonoBehaviour
{
    //member variable
    public float m_Distance = 5;
    public float rollAngle;
    public float rotAngle;
    public Transform Player;


    //member method
    private void updateCameraPos()
    {
        Vector3 cameraPos;
        Vector3 playerPos;
        float cameraHeight, cameraD;
        //将角度转为弧度  ---- 公式为 角度 * Mathf.Pi * 2 / 360;
        float roll = rollAngle * Mathf.PI * 2 / 360; //xz平面
        float rot = rotAngle * Mathf.PI * 2 / 360; //yz平面


        playerPos = Player.position;
        cameraHeight = m_Distance * Mathf.Sin(roll);
        cameraD = m_Distance * Mathf.Cos(roll);

    }

}
