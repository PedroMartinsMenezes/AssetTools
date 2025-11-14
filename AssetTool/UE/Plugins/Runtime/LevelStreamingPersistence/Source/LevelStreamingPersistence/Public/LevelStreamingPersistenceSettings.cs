namespace AssetTool
{
    [JsonAsset("LevelStreamingPersistenceSettings")]
    public class ULevelStreamingPersistenceSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}