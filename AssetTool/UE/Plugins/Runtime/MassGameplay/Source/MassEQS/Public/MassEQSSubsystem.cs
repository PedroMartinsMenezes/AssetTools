namespace AssetTool
{
    [JsonAsset("MassEQSSubsystem")]
    public class UMassEQSSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}