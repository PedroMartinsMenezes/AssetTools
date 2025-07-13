namespace AssetTool
{
    [JsonAsset("EditorDataStorage")]
    public class UEditorDataStorage : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}