namespace AssetTool
{
    [JsonAsset("PCGUnionSettings")]
    public class UPCGUnionSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}