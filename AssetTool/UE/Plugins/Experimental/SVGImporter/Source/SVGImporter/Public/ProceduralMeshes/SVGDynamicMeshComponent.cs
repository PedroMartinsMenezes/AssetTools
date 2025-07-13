namespace AssetTool
{
    [JsonAsset("SVGDynamicMeshComponent")]
    public class USVGDynamicMeshComponent : USVGBaseDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}