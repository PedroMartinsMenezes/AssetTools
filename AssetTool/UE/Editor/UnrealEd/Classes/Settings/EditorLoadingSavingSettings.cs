namespace AssetTool
{
    [JsonAsset("EditorLoadingSavingSettings")]
    public class UEditorLoadingSavingSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}