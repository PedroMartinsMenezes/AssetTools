namespace AssetTool
{
    [JsonAsset("MassTraitRepository")]
    public class UMassTraitRepository : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassDebugEntitySubsystem")]
    public class UMassDebugEntitySubsystem : UMassEntitySubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}