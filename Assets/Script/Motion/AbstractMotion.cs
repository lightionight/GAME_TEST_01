using UnityEngine;

//包含运动抽象类和运动数据结构
namespace GAME_TEST_01.Motion
{
    public abstract class AbstractMotion
    {
        public abstract MotionData motionData { get; set; }
        public abstract Vector3 currentPos { set; get; }
        public abstract Vector3 targetPos { set; get; }
        public abstract float speed { set; get; }
    }
}