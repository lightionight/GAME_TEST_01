using System.Collections;
using UnityEngine;
// Ref : https://blog.csdn.net/FransicZhang/article/details/78194888

namespace Assets.CsScript.Level_3
{
    public class SphereMotion : MonoBehaviour
    {
        private Vector3 centerPos;
        private Vector3 circlePos;
        private float m_R = 5;
        private float x2, y2, z2;
        private void Start()
        {
            //centerPos =
            //circlePos = 
            x2 = circlePos.x - circlePos.x;
            y2 = circlePos.y - circlePos.y;
            z2 = circlePos.z - circlePos.z;
            x2 *= x2;
            y2 *= y2;
            z2 *= z2;

        }

    }
}