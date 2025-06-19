namespace AssetTool
{
    [JsonAsset("CommonUIEditorSettings")]
    public class UCommonUIEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}