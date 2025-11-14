namespace AssetTool
{
    [JsonAsset("DisplayClusterScreenComponent")]
    public class UDisplayClusterScreenComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}