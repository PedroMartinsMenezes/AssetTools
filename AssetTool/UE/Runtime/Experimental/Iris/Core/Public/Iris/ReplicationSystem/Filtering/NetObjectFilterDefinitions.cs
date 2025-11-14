namespace AssetTool
{
    [JsonAsset("NetObjectFilterDefinitions")]
    public class UNetObjectFilterDefinitions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}