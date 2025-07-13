namespace AssetTool
{
    [JsonAsset("SVGShapesParentActor")]
    public class ASVGShapesParentActor : ASVGDynamicMeshesContainerActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}