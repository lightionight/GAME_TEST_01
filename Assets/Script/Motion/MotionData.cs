using UnityEngine;

namespace GAME_TEST_01.Motion
{
    public struct MotionData
    {
        Vector3 currentPos;
        Vector3 targetPos;
        float speed;
        public MotionData(Vector3 currentPos, Vector3 targetPos, float speed)
        {
            this.currentPos = currentPos;
            this.targetPos = targetPos;
            this.speed = speed;
        }
    }
}
