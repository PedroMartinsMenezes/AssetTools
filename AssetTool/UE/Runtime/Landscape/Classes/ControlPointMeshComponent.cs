namespace AssetTool
{
    [JsonAsset("ControlPointMeshComponent")]
    public class UControlPointMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}