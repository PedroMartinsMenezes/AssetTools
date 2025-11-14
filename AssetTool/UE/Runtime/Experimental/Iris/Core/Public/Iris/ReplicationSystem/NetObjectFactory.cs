namespace AssetTool
{
    [JsonAsset("NetObjectFactory")]
    public class UNetObjectFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}