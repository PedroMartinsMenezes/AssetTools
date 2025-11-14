namespace AssetTool
{
    [JsonAsset("PCGUnionSettings")]
    public class UPCGUnionSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}