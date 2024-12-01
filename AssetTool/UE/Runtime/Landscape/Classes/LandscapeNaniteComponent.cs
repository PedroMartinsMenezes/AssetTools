namespace AssetTool
{
    [JsonAsset("LandscapeNaniteComponent")]
    public class ULandscapeNaniteComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}