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
    //public class FRotation3 : Rotation3 { }

    //public class TVector2 : FVector2f { }//TODO do not inherit

    //public class TVector3f : FVector3f { }
    //public class TVector3d : FVector3f { }
    //public class TVector3 : FVector3f { } //TODO do not inherit

    //public class TVector4f : FVector4f { }
    //public class TVector4d : FVector4d { }
    //public class TVector4 : FVector4f { }//TODO do not inherit

    public class TVector3i : ITransferible
    {
        public int32 X;
        public int32 Y;
        public int32 Z;

        public virtual ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }
}
