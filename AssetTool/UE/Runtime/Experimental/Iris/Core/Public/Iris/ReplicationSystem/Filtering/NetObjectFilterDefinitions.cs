namespace AssetTool
{
    [JsonAsset("NetObjectFilterDefinitions")]
    public class UNetObjectFilterDefinitions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}