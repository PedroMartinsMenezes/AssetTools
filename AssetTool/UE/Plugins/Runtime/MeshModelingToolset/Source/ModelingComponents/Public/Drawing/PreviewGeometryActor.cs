namespace AssetTool
{
    [JsonAsset("PreviewGeometryActor")]
    public class APreviewGeometryActor : AInternalToolFrameworkActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PreviewGeometry")]
    public class UPreviewGeometry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}