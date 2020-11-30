using System.Collections;
using UnityEngine;
using GAME_TEST_01.Motion;

/*
 *  包含原子抽象和接口
 */
namespace GAME_TEST_01.Atom
{
    public abstract class Atom
    {
        public abstract AtomData atomData { get; set; }
        public abstract MotionData MotionData { get; set; }
        public abstract Vector3 position { get; set; }
        //public abstract 父类是谁
        public abstract float electicValue { get; set; }
        public abstract Color Color { get; set; }
        public abstract float Size { get; set; }
        public abstract AtomType AtomType { get;}
        


    }
    interface IAtom
    {
        void ChangeFather();
        void ChangeColor(Color color);
        void ChangeElecticValue(float electicValue);
        void Move(MotionData motionData);
        void Rotate(MotionData motionData);
        void Scale(MotionData motionData);

    }

}