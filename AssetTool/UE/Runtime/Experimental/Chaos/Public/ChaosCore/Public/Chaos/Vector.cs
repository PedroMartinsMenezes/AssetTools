global using TVector2 = AssetTool.FVector2f;
global using TVector3 = AssetTool.FVector3f;
global using TVector4 = AssetTool.FVector4f;

namespace AssetTool
{
    public class Vector
    {
        public TVector2 MyTVector2;
        public TVector3 MyTVector3;
        public TVector4 MyTVector4;
    }
}

namespace AssetTool.Chaos
{
    public class TVector3i : ITransferible
    {
        public int32 X;
        public int32 Y;
        public int32 Z;

        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }
}
