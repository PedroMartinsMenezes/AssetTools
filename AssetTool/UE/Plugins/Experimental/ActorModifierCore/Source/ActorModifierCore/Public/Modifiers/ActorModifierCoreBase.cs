namespace AssetTool
{
    [JsonAsset("ActorModifierCoreBase")]
    public class UActorModifierCoreBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}