using System.Collections;
using UnityEngine;
// Ref : https://blog.csdn.net/FransicZhang/article/details/78194888

namespace Assets.CsScript.Level_3
{
    public class SphereMotion : MonoBehaviour
    {
        
        private Vector3 targetPos;
        private float x_Deviation, y_Deviation, z_Deviation;// x, y, z 偏移值
        private float _Angle;
        public float _Radius = 3;

        public float revolutionSpeed;

        private void Update()
        {
            transform.position = circleAround();
        }

        /// <summary>
        ///  Return Position vector3
        /// </summary>
        /// <returns></returns>
        Vector3 circleAround()
        {
            _Angle += revolutionSpeed * Time.deltaTime;
            if (_Angle > 360)
                _Angle -= 360;
            float x = targetPos.x + Mathf.Cos(_Angle * (Mathf.PI / 180)) * _Radius * revolutionSpeed;
            float y = targetPos.y + Mathf.Sin(_Angle * (Mathf.PI / 180)) * _Radius * revolutionSpeed;
            float z = targetPos.z + Mathf.Sin(_Angle * (Mathf.PI / 180)) * _Radius * revolutionSpeed;

            
            return new Vector3(x, 0, z);
        }

    }
}