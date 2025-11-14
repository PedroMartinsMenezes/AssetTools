namespace AssetTool
{
    [JsonAsset("EditorDataStorage")]
    public class UEditorDataStorage : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}