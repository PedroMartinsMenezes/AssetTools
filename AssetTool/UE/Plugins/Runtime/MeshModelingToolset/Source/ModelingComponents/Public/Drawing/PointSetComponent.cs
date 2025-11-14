namespace AssetTool
{
    [JsonAsset("PointSetComponent")]
    public class UPointSetComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}