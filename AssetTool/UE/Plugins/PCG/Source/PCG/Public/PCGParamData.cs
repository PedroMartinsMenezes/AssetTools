namespace AssetTool
{
    [JsonAsset("PCGParamData")]
    public class UPCGParamData : UPCGData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}