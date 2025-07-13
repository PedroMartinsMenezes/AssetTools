namespace AssetTool
{
    [JsonAsset("EditorUtilitySubsystem")]
    public class UEditorUtilitySubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}