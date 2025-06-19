namespace AssetTool
{
    [JsonAsset("ActorElementSelectionInterface")]
    public class UActorElementSelectionInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}