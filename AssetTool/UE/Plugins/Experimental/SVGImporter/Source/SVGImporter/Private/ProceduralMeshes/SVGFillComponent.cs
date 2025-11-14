namespace AssetTool
{
    [JsonAsset("SVGFillComponent")]
    public class USVGFillComponent : USVGDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}