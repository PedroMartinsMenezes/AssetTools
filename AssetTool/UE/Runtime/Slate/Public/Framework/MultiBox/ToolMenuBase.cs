namespace AssetTool
{
    [JsonAsset("ToolMenuBase")]
    public class UToolMenuBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}