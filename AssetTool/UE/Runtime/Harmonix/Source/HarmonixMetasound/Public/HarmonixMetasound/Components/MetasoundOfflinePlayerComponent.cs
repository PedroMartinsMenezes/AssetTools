namespace AssetTool
{
    [JsonAsset("MetasoundOfflinePlayerComponent")]
    public class UMetasoundOfflinePlayerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}