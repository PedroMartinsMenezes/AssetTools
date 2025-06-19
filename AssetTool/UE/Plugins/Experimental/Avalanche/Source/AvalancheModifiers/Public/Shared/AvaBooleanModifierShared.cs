namespace AssetTool
{
    [JsonAsset("AvaBooleanModifierShared")]
    public class UAvaBooleanModifierShared : UActorModifierCoreSharedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}