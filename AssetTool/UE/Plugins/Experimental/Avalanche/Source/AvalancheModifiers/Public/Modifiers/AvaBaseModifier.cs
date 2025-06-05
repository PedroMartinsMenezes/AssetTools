namespace AssetTool
{
    [JsonAsset("AvaBaseModifier")]
    public class UAvaBaseModifier : UActorModifierCoreBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}