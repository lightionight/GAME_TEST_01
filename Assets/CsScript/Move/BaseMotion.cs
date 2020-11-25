using UnityEngine;

namespace GAME_TEST_01.Move
{
    /// <summary>
    ///  All Object in game motion base Class;
    /// </summary>
    public abstract class BaseMotion
    {
        /// <summary>
        /// 圆周运动半径
        /// </summary>
        public abstract float R { get; set; }
        /// <summary>
        /// 设置移动速度
        /// </summary>
        public abstract float speed { get; set; }
        /// <summary>
        /// 圆周运动圆心
        /// </summary>
        /// <summary>
        public abstract Vector3 targetPos { get; set; }
        /// 当前位置
        /// </summary>
        public abstract Vector3 currentPos { get;}
        public abstract void calculatePos();
    }
    public struct MotionData
    {
        public float m_r;
        public float m_speed;
        public float m_Angle;
        public Vector3 m_targetPos;
        public Vector3 m_currentPos;
    }
    public interface IMotion
    {
        /// <summary>
        /// 计算出当前运动物体的位置
        /// </summary>
        /// <returns></returns>
        public Vector3 getPos(BaseMotion.MotionData motionData);
    }

}