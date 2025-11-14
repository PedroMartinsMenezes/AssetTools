namespace AssetTool
{
    [JsonAsset("SingleClickInputBehavior")]
    public class USingleClickInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalSingleClickInputBehavior")]
    public class ULocalSingleClickInputBehavior : USingleClickInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}