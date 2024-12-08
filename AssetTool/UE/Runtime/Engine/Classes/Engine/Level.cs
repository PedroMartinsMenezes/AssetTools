namespace AssetTool
{
    [JsonAsset("ActorContainer")]
    public class UActorContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Level")]
    public class ULevel : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}