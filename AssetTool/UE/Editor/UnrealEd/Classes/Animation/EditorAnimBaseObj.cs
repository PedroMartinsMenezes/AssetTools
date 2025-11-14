namespace AssetTool
{
    [JsonAsset("EditorAnimBaseObj")]
    public class UEditorAnimBaseObj : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}