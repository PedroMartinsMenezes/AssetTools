namespace AssetTool
{
    [JsonAsset("EditorValidator")]
    public class UEditorValidator : UEditorValidatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}