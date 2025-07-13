namespace AssetTool
{
    [JsonAsset("TriangleSetComponent")]
    public class UTriangleSetComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}