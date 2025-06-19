namespace AssetTool
{
    [JsonAsset("InteractiveToolsContext")]
    public class UInteractiveToolsContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}