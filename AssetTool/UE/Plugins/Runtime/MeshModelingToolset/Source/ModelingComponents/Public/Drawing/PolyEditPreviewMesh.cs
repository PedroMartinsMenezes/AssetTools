namespace AssetTool
{
    [JsonAsset("PolyEditPreviewMesh")]
    public class UPolyEditPreviewMesh : UPreviewMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}