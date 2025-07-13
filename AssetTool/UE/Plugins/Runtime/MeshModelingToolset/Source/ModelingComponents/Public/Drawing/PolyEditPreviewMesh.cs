namespace AssetTool
{
    [JsonAsset("PolyEditPreviewMesh")]
    public class UPolyEditPreviewMesh : UPreviewMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}