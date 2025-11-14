namespace AssetTool
{
    [JsonAsset("VideoDeinterlacer")]
    public class UVideoDeinterlacer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BobDeinterlacer")]
    public class UBobDeinterlacer : UVideoDeinterlacer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BlendDeinterlacer")]
    public class UBlendDeinterlacer : UVideoDeinterlacer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DiscardDeinterlacer")]
    public class UDiscardDeinterlacer : UVideoDeinterlacer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}