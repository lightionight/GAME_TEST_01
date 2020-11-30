using UnityEngine;
using GAME_TEST_01.Motion;

namespace GAME_TEST_01.Atom
{
    public class Proton: AtomBase, IAtom
    {
        public Proton() : base() { }
        public Proton(MotionData motionData) : base(motionData)
        {

        }
        public Proton(AtomData atomData) : base(atomData)
        {

        }


        public override void Move(MotionData motionData)
        {
            
        }
        public override void Rotate(MotionData motionData)
        {

        }
        public override void Scale(MotionData motionData)
        {

        }
    }
}