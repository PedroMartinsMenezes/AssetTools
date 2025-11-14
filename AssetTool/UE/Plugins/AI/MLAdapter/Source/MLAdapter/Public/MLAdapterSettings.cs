namespace AssetTool
{
    [JsonAsset("MLAdapterSettings")]
    public class UMLAdapterSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}