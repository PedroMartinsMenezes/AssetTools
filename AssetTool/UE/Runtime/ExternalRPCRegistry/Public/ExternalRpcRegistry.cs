namespace AssetTool
{
    [JsonAsset("ExternalRpcRegistry")]
    public class UExternalRpcRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}