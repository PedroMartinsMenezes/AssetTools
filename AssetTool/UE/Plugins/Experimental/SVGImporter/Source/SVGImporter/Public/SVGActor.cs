namespace AssetTool
{
    [JsonAsset("SVGActor")]
    public class ASVGActor : ASVGDynamicMeshesContainerActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}