
namespace AssetTool
{
    public class FAnimCurveBase
    {
        public UInt16 CurveUid;

        public void PostSerializeFixup(Transfer transfer)
        {
            if (!Supports.SmartNameRefactor && Supports.VER_UE4_SKELETON_ADD_SMARTNAMES)
            {
                transfer.Move(ref CurveUid);
            }
        }
    }

    public class FFloatCurve : FAnimCurveBase
    {
    }

    public class FVectorCurve : FAnimCurveBase
    {
    }

    public class FTransformCurve : FAnimCurveBase
    {
    }
}