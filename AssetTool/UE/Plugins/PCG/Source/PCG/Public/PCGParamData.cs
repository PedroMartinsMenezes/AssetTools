namespace AssetTool
{
    [JsonAsset("PCGParamData")]
    public class UPCGParamData : UPCGData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}