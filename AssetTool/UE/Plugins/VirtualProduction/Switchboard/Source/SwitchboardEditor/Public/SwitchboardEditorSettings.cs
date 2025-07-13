namespace AssetTool
{
    [JsonAsset("SwitchboardEditorSettings")]
    public class USwitchboardEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}