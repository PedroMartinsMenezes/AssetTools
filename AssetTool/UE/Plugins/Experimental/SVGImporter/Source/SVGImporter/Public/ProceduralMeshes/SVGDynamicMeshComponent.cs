namespace AssetTool
{
    [JsonAsset("SVGDynamicMeshComponent")]
    public class USVGDynamicMeshComponent : USVGBaseDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}