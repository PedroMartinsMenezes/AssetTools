namespace AssetTool
{
    [JsonAsset("GameplayTask")]
    public class UGameplayTask : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}