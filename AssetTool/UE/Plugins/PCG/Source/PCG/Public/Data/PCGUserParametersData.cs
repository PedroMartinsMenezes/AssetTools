namespace AssetTool
{
    [JsonAsset("PCGUserParametersData")]
    public class UPCGUserParametersData : UPCGData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}