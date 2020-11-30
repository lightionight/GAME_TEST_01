using UnityEngine;

// Contain AtomData And Type Enum;
namespace GAME_TEST_01.Atom
{
    public struct AtomData
    {
        public Vector3 position;
        public float electicValue;
        public Color color;
        public float size;
        public AtomType atomType;
        public AtomData(Vector3 position, float electicValue, Color color, float size, AtomType atomType)
        {
            this.position = position;
            this.electicValue = electicValue;
            this.color = color;
            this.size = size;
            this.atomType = atomType;
        }

    }
    public enum AtomType
    {
        Proton,
        Neutron,
        Electron,
    }
}