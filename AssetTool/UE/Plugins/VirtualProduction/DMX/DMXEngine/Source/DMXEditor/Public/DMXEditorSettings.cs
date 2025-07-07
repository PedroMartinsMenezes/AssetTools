namespace AssetTool
{
    [JsonAsset("DMXEditorSettings")]
    public class UDMXEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}