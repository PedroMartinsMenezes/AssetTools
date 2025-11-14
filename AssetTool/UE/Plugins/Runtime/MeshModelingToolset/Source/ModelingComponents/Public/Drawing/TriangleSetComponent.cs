namespace AssetTool
{
    [JsonAsset("TriangleSetComponent")]
    public class UTriangleSetComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}