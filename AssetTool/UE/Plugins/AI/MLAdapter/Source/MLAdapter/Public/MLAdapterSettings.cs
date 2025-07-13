namespace AssetTool
{
    [JsonAsset("MLAdapterSettings")]
    public class UMLAdapterSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}