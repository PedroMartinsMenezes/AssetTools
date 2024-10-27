namespace AssetTool
{
    [JsonAsset("DrawSphereComponent")]
    public class UDrawSphereComponent : USphereComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}