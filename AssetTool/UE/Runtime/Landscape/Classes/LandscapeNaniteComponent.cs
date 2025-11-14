namespace AssetTool
{
    [JsonAsset("LandscapeNaniteComponent")]
    public class ULandscapeNaniteComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}