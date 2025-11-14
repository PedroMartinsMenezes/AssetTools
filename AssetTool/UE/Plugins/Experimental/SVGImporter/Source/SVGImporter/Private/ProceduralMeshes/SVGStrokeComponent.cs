namespace AssetTool
{
    [JsonAsset("SVGStrokeComponent")]
    public class USVGStrokeComponent : USVGDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}