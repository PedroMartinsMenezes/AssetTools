namespace AssetTool
{
    [JsonAsset("ControlPointMeshComponent")]
    public class UControlPointMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}