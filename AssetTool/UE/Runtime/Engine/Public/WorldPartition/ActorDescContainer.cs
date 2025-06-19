namespace AssetTool
{
    [JsonAsset("ActorDescContainer")]
    public class UActorDescContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}