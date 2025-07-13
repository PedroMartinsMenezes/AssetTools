namespace AssetTool
{
    [JsonAsset("GameNetworkManagerSettings")]
    public class UGameNetworkManagerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}