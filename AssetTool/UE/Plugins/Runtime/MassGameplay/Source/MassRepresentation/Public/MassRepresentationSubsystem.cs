namespace AssetTool
{
    [JsonAsset("MassRepresentationSubsystem")]
    public class UMassRepresentationSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}