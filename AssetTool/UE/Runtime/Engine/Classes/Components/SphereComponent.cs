namespace AssetTool
{
    [JsonAsset("SphereComponent")]
    public class USphereComponent : UShapeComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}