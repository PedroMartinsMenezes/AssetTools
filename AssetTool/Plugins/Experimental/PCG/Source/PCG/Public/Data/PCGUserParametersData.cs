namespace AssetTool
{
    [JsonAsset("PCGUserParametersData")]
    public class UPCGUserParametersData : UPCGData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}