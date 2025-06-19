namespace AssetTool
{
    [JsonAsset("DisplayClusterScreenComponent")]
    public class UDisplayClusterScreenComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}