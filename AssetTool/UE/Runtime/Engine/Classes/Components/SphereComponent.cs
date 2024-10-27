namespace AssetTool
{
    [JsonAsset("SphereComponent")]
    public class USphereComponent : UShapeComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}