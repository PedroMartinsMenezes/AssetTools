namespace AssetTool
{
    [JsonAsset("ActorDescContainer")]
    public class UActorDescContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}