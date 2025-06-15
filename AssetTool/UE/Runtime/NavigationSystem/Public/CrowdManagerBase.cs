namespace AssetTool
{
    [JsonAsset("CrowdManagerBase")]
    public class UCrowdManagerBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}