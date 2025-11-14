namespace AssetTool
{
    [JsonAsset("GameplayBehaviorConfig")]
    public class UGameplayBehaviorConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}