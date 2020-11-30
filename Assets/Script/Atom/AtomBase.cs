using UnityEngine;
using GAME_TEST_01.Motion;
namespace GAME_TEST_01.Atom
{
    public class AtomBase: Atom, IAtom
    {
        protected Transform m_transform;
        protected AtomData m_AtomData;
        protected MotionData m_MotionData;
        
        public AtomBase()
        {
            m_AtomData = new AtomData();
            m_MotionData = new MotionData();
        }
        public AtomBase(AtomData atomData, MotionData motionData)
        {
            m_AtomData = atomData;
            m_MotionData = motionData;
        }
        public AtomBase(AtomData atomData)
        {
            m_AtomData = atomData;
            m_MotionData = new MotionData();
        }
        public AtomBase(MotionData motionData)
        {
            m_AtomData = new AtomData();
            m_MotionData = motionData;
        }
        public override AtomData atomData
        {
            get => m_AtomData;
            set => m_AtomData = value;
        }
        public override MotionData MotionData
        {
            get => m_MotionData;
            set => m_MotionData = value;
        }
        public override Vector3 position
        {
            get => m_AtomData.position;
            set => m_AtomData.position = value;
        }
        public override float electicValue
        {
            get => m_AtomData.electicValue;
            set => m_AtomData.electicValue = value;
        }
        public override Color Color
        {
            get => m_AtomData.color;
            set => m_AtomData.color = value;
        }
        public override float Size
        {
            get => m_AtomData.size;
            set => m_AtomData.size = value;
        }
        public override AtomType AtomType
        {
            get => m_AtomData.atomType;
        }

        public virtual void ChangeFather()
        {

        }
        public virtual void ChangeColor(Color color)
        {

        }
        public virtual void ChangeElecticValue(float electicValue)
        {

        }
        public virtual void Move(MotionData motionData)
        {

        }
        public virtual void Rotate(MotionData motionData)
        {

        }
        public virtual void Scale(MotionData motionData)
        {

        }
    }
}