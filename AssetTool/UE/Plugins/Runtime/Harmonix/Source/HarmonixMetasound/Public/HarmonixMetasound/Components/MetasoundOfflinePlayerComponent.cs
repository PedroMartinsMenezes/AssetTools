namespace AssetTool
{
    [JsonAsset("MetasoundOfflinePlayerComponent")]
    public class UMetasoundOfflinePlayerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}