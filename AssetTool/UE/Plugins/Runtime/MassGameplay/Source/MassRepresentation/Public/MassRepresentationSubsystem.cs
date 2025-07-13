namespace AssetTool
{
    [JsonAsset("MassRepresentationSubsystem")]
    public class UMassRepresentationSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}