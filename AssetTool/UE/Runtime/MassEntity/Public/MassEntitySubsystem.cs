namespace AssetTool
{
    [JsonAsset("MassEntitySubsystem")]
    public class UMassEntitySubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}