namespace AssetTool
{
    [JsonAsset("CrowdManagerBase")]
    public class UCrowdManagerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}