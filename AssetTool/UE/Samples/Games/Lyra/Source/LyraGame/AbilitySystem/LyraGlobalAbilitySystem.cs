namespace AssetTool
{
    [JsonAsset("LyraGlobalAbilitySystem")]
    public class ULyraGlobalAbilitySystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}