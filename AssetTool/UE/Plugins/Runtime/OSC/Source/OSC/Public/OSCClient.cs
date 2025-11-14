namespace AssetTool
{
    [JsonAsset("OSCClient")]
    public class UOSCClient : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}