namespace AssetTool
{
    [JsonAsset("SVGBaseDynamicMeshComponent")]
    public class USVGBaseDynamicMeshComponent : UDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}