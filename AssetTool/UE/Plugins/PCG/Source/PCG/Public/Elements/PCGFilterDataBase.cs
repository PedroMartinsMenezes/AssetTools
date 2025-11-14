namespace AssetTool
{
    [JsonAsset("PCGFilterDataBaseSettings")]
    public class UPCGFilterDataBaseSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}