namespace AssetTool
{
    [JsonAsset("AvaBaseModifier")]
    public class UAvaBaseModifier : UActorModifierCoreBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}