namespace AssetTool
{
    [JsonAsset("AbilitySystemCheatManagerExtension")]
    public class UAbilitySystemCheatManagerExtension : UCheatManagerExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}