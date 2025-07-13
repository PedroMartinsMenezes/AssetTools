namespace AssetTool
{
    [JsonAsset("MassCrowdRepresentationSubsystem")]
    public class UMassCrowdRepresentationSubsystem : UMassRepresentationSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}