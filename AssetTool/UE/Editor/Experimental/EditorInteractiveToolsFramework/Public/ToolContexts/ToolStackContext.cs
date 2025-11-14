namespace AssetTool
{
    [JsonAsset("ToolStackContext")]
    public class UToolStackContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}