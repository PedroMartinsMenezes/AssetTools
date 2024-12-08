namespace AssetTool
{
    [JsonAsset("ActorDescContainer")]
    public class UActorDescContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}