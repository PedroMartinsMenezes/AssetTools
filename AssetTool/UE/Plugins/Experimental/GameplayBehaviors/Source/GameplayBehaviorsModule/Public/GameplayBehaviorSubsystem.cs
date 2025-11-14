namespace AssetTool
{
    [JsonAsset("GameplayBehaviorSubsystem")]
    public class UGameplayBehaviorSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}