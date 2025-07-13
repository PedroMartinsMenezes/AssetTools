namespace AssetTool
{
    [JsonAsset("SVGActor")]
    public class ASVGActor : ASVGDynamicMeshesContainerActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}