namespace AssetTool
{
    [JsonAsset("GameplayBehavior")]
    public class UGameplayBehavior : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}