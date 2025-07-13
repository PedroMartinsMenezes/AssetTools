namespace AssetTool
{
    [JsonAsset("MassEQSSubsystem")]
    public class UMassEQSSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}