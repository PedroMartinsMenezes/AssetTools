namespace AssetTool
{
    [JsonAsset("GameplayBehaviorSubsystem")]
    public class UGameplayBehaviorSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}