namespace AssetTool
{
    [JsonAsset("MassActorEditorSubsystem")]
    public class UMassActorEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}