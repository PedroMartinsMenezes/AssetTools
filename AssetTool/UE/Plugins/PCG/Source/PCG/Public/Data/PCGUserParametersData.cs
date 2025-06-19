namespace AssetTool
{
    [JsonAsset("PCGUserParametersData")]
    public class UPCGUserParametersData : UPCGData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}