namespace AssetTool
{
    [JsonAsset("EditorGeometryGenerationSubsystem")]
    public class UEditorGeometryGenerationSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorGeometryGenerationManager")]
    public class UEditorGeometryGenerationManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}