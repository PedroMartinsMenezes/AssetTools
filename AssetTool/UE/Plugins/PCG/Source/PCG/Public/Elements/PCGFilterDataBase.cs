namespace AssetTool
{
    [JsonAsset("PCGFilterDataBaseSettings")]
    public class UPCGFilterDataBaseSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}