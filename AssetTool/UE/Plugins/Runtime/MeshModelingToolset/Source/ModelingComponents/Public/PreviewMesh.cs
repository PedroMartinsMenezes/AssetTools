namespace AssetTool
{
    [JsonAsset("PreviewMeshActor")]
    public class APreviewMeshActor : AInternalToolFrameworkActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PreviewMesh")]
    public class UPreviewMesh : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}