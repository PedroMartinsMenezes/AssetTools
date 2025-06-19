namespace AssetTool
{
    [JsonAsset("LandscapeNaniteComponent")]
    public class ULandscapeNaniteComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}