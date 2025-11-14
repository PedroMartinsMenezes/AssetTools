namespace AssetTool
{
    [JsonAsset("MockRootMotionSource")]
    public class UMockRootMotionSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockRootMotionSourceClassMap")]
    public class UMockRootMotionSourceClassMap : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockRootMotionSource_Montage")]
    public class UMockRootMotionSource_Montage : UMockRootMotionSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockRootMotionSource_Curve")]
    public class UMockRootMotionSource_Curve : UMockRootMotionSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockRootMotionSource_MoveToLocation")]
    public class UMockRootMotionSource_MoveToLocation : UMockRootMotionSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}