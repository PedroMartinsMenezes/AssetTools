namespace AssetTool
{
    [JsonAsset("DrawSphereComponent")]
    public class UDrawSphereComponent : USphereComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}