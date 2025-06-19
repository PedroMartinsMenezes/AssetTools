namespace AssetTool
{
    [JsonAsset("AvaBaseModifier")]
    public class UAvaBaseModifier : UActorModifierCoreBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}