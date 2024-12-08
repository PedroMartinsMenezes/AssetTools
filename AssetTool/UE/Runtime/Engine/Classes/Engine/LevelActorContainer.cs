namespace AssetTool
{
    [JsonAsset("LevelActorContainer")]
    public class ULevelActorContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}