namespace AssetTool
{
    [JsonAsset("ControlPointMeshComponent")]
    public class UControlPointMeshComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}