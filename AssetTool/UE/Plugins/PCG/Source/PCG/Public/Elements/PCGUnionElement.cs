namespace AssetTool
{
    [JsonAsset("PCGUnionSettings")]
    public class UPCGUnionSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}