namespace AssetTool
{
    [JsonAsset("MassCrowdRepresentationSubsystem")]
    public class UMassCrowdRepresentationSubsystem : UMassRepresentationSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}