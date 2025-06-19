namespace AssetTool
{
    [JsonAsset("SphereComponent")]
    public class USphereComponent : UShapeComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}