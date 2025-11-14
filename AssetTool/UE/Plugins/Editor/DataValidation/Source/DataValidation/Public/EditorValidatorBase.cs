namespace AssetTool
{
    [JsonAsset("EditorValidatorBase")]
    public class UEditorValidatorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}