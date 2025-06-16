namespace AssetTool
{
    [JsonAsset("PCGParamData")]
    public class UPCGParamData : UPCGData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}