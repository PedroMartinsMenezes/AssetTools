namespace AssetTool
{
    [JsonAsset("MassEntitySubsystem")]
    public class UMassEntitySubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}