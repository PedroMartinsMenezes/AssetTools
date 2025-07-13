namespace AssetTool
{
    [JsonAsset("AbilitySystemCheatManagerExtension")]
    public class UAbilitySystemCheatManagerExtension : UCheatManagerExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}