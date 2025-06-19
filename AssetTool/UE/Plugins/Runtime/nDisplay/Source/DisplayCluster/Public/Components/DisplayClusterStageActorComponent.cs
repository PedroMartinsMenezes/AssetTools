namespace AssetTool
{
    [JsonAsset("DisplayClusterStageActorComponent")]
    public class UDisplayClusterStageActorComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}