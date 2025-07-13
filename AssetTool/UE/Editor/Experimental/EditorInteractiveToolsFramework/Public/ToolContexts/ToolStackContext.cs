namespace AssetTool
{
    [JsonAsset("ToolStackContext")]
    public class UToolStackContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}