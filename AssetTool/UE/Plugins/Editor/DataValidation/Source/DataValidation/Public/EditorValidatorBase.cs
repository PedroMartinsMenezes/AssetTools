namespace AssetTool
{
    [JsonAsset("EditorValidatorBase")]
    public class UEditorValidatorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}