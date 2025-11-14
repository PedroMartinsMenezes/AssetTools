namespace AssetTool
{
    [JsonAsset("GameNetworkManagerSettings")]
    public class UGameNetworkManagerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}