namespace AssetTool
{
    [JsonAsset("BasicTriangleSetComponentBase")]
    public class UBasicTriangleSetComponentBase : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Basic2DTriangleSetComponent")]
    public class UBasic2DTriangleSetComponent : UBasicTriangleSetComponentBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Basic3DTriangleSetComponent")]
    public class UBasic3DTriangleSetComponent : UBasicTriangleSetComponentBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}