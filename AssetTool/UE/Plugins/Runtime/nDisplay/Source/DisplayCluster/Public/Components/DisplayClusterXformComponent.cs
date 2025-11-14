namespace AssetTool
{
    [JsonAsset("DisplayClusterXformComponent")]
    public class UDisplayClusterXformComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}