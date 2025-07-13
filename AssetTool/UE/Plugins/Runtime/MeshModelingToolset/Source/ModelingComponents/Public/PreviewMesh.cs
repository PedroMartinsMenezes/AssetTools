namespace AssetTool
{
    [JsonAsset("PreviewMeshActor")]
    public class APreviewMeshActor : AInternalToolFrameworkActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PreviewMesh")]
    public class UPreviewMesh : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}