using UnityEngine;

namespace GAME_TEST_01.Move
{
    public class CircularMotion : BaseMotion, IMotion
    {
        
        private MotionData circularData;
        
        public CircularMotion()
        {
            circularData.m_r = 3f;
            circularData.m_speed = 10f;
            circularData.m_targetPos = new Vector3(0, 0, 0);
            circularData.m_currentPos = new Vector3(0, 0, 0);
        }
        public CircularMotion(float r, float speed)
        {
            m_r = r;
            m_speed = speed;
            m_targetPos = new Vector3(0, 0, 0);
            m_currentPos = new Vector3(0, 0, 0);
        }
        public CircularMotion(float r, float speed, Vector3 targetPos)
        {
            m_r = r;
            m_speed = speed;
            m_targetPos = targetPos;
            m_currentPos = new Vector3(0, 0, 0);
        }
        public override float R
        {
            get => m_r;
            set => m_r = value;
        }
        public override float speed
        {
            get => m_speed;
            set => m_speed = value;
        }
        public override Vector3 targetPos
        {
            get => m_targetPos;
            set => m_targetPos = value;
        }
        public override Vector3 currentPos
        {
            get => m_currentPos;
        }
        /// <summary>
        /// 使用角速度实现
        /// </summary>
        /// <returns></returns>
        public Vector3 calculatePos(BaseMotion.MotionData motionData)
        {
        //Ref：https://www.zhihu.com/question/20149818
        // https://www.zhihu.com/question/20149818
        }
            //_Angle += m_speed * Time.deltaTime;
            //if (_Angle > 360)
            // {
            //    _Angle -= 360;
            // }
            //m_currentPos.x = targetPos.x + Mathf.Cos(_Angle * (Mathf.PI / 180)) * m_r * m_speed;
            //m_currentPos.z = targetPos.z + Mathf.Cos(_Angle * (Mathf.PI / 180)) * m_r * m_speed;
            //return m_currentPos;
            

    }
}