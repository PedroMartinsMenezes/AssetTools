namespace AssetTool
{
    [JsonAsset("MassEntityEditorSubsystem")]
    public class UMassEntityEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}