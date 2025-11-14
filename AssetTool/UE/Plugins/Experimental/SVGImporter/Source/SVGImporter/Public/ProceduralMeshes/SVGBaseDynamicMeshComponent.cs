namespace AssetTool
{
    [JsonAsset("SVGBaseDynamicMeshComponent")]
    public class USVGBaseDynamicMeshComponent : UDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}