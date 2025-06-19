namespace AssetTool
{
    [JsonAsset("ActorContainer")]
    public class UActorContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Level")]
    public class ULevel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}