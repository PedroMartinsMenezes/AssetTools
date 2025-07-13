namespace AssetTool
{
    [JsonAsset("DirtyFilesChangelistValidator")]
    public class UDirtyFilesChangelistValidator : UEditorValidatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}