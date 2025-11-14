namespace AssetTool
{
    [JsonAsset("NetObjectPrioritizerDefinitions")]
    public class UNetObjectPrioritizerDefinitions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}