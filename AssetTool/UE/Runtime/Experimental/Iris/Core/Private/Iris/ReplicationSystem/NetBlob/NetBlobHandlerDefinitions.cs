namespace AssetTool
{
    [JsonAsset("NetBlobHandlerDefinitions")]
    public class UNetBlobHandlerDefinitions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}