namespace AssetTool
{
    [JsonAsset("DrawSphereComponent")]
    public class UDrawSphereComponent : USphereComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}