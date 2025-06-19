namespace AssetTool
{
    [JsonAsset("EditorAnimBaseObj")]
    public class UEditorAnimBaseObj : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}