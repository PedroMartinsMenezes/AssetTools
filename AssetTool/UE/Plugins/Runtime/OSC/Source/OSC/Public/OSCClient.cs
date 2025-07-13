namespace AssetTool
{
    [JsonAsset("OSCClient")]
    public class UOSCClient : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}