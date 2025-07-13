namespace AssetTool
{
    [JsonAsset("SVGStrokeComponent")]
    public class USVGStrokeComponent : USVGDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}