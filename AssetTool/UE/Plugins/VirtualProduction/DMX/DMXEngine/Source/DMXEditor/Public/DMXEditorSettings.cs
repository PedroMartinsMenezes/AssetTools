namespace AssetTool
{
    [JsonAsset("DMXEditorSettings")]
    public class UDMXEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}