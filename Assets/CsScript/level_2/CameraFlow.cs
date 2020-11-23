using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*************************************************************
 *   ---------------Camera FLow implement--------------------
 *************************************************************/
// Ref : https://blog.csdn.net/qq_14942529/article/details/82584702
// 四元数 Ref：https://www.zhihu.com/question/23005815

public class CameraFlow : MonoBehaviour
{
    //member variable
    public float m_Distance = 15;
    public float rollAngle = 50;
    public float rotAngle = 180;
    public Transform Player;


    //member method
    private void updateCameraPos()
    {
        Vector3 cameraPos;
        Vector3 playerPos;
        float cameraY, cameraD, cameraX, cameraZ;
        //将角度转为弧度  ---- 公式为 角度 * Mathf.Pi * 2 / 360;
        float roll = rollAngle * Mathf.PI * 2 / 360; //xz平面
        float rot = rotAngle * Mathf.PI * 2 / 360; //yz平面


        playerPos = Player.position;
        cameraY = m_Distance * Mathf.Sin(roll);
        cameraD = m_Distance * Mathf.Cos(roll);
        cameraX = cameraD * Mathf.Sin(rot);
        cameraZ = cameraD * Mathf.Cos(rot);
        cameraPos.x = playerPos.x + cameraX;
        cameraPos.y = playerPos.y + cameraY;
        cameraPos.z = playerPos.z + cameraZ;
        transform.position = cameraPos;
        transform.LookAt(Player);


    }
    //MonoBehaviour
    private void Update()
    {
        updateCameraPos();
    }
}
