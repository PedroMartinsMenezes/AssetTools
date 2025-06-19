namespace AssetTool
{
    [JsonAsset("LevelActorContainer")]
    public class ULevelActorContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}