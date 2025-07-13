namespace AssetTool
{
    [JsonAsset("PointSetComponent")]
    public class UPointSetComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}