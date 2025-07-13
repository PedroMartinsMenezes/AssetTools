namespace AssetTool
{
    [JsonAsset("NetObjectPrioritizerDefinitions")]
    public class UNetObjectPrioritizerDefinitions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}