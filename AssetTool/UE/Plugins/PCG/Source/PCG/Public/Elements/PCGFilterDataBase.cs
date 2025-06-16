namespace AssetTool
{
    [JsonAsset("PCGFilterDataBaseSettings")]
    public class UPCGFilterDataBaseSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}