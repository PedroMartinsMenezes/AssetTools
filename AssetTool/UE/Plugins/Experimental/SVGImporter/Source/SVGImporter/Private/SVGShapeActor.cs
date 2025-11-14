namespace AssetTool
{
    [JsonAsset("SVGShapeActor")]
    public class ASVGShapeActor : ASVGDynamicMeshesContainerActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}