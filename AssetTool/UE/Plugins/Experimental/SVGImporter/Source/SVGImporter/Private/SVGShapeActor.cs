namespace AssetTool
{
    [JsonAsset("SVGShapeActor")]
    public class ASVGShapeActor : ASVGDynamicMeshesContainerActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}