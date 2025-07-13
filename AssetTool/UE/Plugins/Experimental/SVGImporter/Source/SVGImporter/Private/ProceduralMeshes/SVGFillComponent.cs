namespace AssetTool
{
    [JsonAsset("SVGFillComponent")]
    public class USVGFillComponent : USVGDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}