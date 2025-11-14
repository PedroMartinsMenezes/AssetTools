namespace AssetTool
{
    [JsonAsset("MassCrowdRepresentationActorManagement")]
    public class UMassCrowdRepresentationActorManagement : UMassRepresentationActorManagement
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}