namespace AssetTool
{
    [JsonAsset("MassTraitRepository")]
    public class UMassTraitRepository : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassDebugEntitySubsystem")]
    public class UMassDebugEntitySubsystem : UMassEntitySubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}