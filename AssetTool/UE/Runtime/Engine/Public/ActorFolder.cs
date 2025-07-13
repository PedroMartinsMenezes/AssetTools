namespace AssetTool
{
    [JsonAsset("ActorFolder")]
    public class UActorFolder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}