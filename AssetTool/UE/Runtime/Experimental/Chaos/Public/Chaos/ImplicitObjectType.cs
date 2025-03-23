namespace AssetTool
{
    public partial class Chaos
    {
        public enum EImplicitObjectType : byte
        {
            Sphere = 0,
            Box,
            Plane,
            Capsule,
            Transformed,
            Union,
            LevelSet,
            Unknown,
            Convex,
            TaperedCylinder,
            Cylinder,
            TriangleMesh,
            HeightField,
            DEPRECATED_Scaled,
            Triangle,
            UnionClustered,
            TaperedCapsule,
            WeightedLatticeBone,
            ConcreteObjectCount,
            IsWeightedLattice = 1 << 5,
            IsInstanced = 1 << 6,
            IsScaled = 1 << 7
        }
    }
}
