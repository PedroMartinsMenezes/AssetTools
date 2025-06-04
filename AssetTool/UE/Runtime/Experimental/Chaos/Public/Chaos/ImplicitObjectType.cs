namespace AssetTool.Chaos
{
    public partial class Chaos
    {
        [Flags]
        public enum EImplicitObjectType : byte
        {
            Sphere = 0,
            Box = 1,
            Plane = 2,
            Capsule = 3,
            Transformed = 4,
            Union = 5,
            LevelSet = 6,
            Unknown = 7,
            Convex = 8,
            TaperedCylinder = 9,
            Cylinder = 10,
            TriangleMesh = 11,
            HeightField = 12,
            DEPRECATED_Scaled = 13,
            Triangle = 14,
            UnionClustered = 15,
            TaperedCapsule = 16,
            WeightedLatticeBone = 17,

            //Add entries above this line for serialization
            ConcreteObjectCount = 18,
            IsWeightedLattice = 1 << 5,
            IsInstanced = 1 << 6,
            IsScaled = 1 << 7
        }

        public static bool IsInstanced(EImplicitObjectType Type)
        {
            return (Type & EImplicitObjectType.IsInstanced) != 0;
        }

        public static bool IsScaled(EImplicitObjectType Type)
        {
            return (Type & EImplicitObjectType.IsScaled) != 0;
        }

        public static bool IsWeightedLattice(EImplicitObjectType Type)
        {
            return (Type & EImplicitObjectType.IsWeightedLattice) != 0;
        }

        public static EImplicitObjectType GetInnerType(EImplicitObjectType Type)
        {
            return Type & (~(EImplicitObjectType.IsWeightedLattice | EImplicitObjectType.IsScaled | EImplicitObjectType.IsInstanced));
        }
    }
}
