namespace AssetTool
{
    [JsonAsset("PCGEngineSettings")]
    public class UPCGEngineSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}