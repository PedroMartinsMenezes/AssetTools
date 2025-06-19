namespace AssetTool
{
    [JsonAsset("CrowdManagerBase")]
    public class UCrowdManagerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}