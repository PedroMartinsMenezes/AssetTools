namespace AssetTool
{
    [JsonAsset("MassCrowdRepresentationActorManagement")]
    public class UMassCrowdRepresentationActorManagement : UMassRepresentationActorManagement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}