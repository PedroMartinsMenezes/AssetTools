namespace AssetTool
{
    [JsonAsset("MassActorEditorSubsystem")]
    public class UMassActorEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}