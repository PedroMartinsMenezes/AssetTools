namespace AssetTool.Chaos
{
    public class FImplicitBVH : ITransferible
    {
        public FImplicitObject Geometry;
        public FVec3f X;
        public float[] R = [0, 0, 0, 0];
        public int32 RootObjectIndex;

        [Location("FChaosArchive& FImplicitBVHObject::Serialize(FChaosArchive& Ar)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Geometry);
            transfer.Move(ref X);
            transfer.Move(ref R, 4);
            transfer.Move(ref RootObjectIndex);
            return this;
        }
    }
}
