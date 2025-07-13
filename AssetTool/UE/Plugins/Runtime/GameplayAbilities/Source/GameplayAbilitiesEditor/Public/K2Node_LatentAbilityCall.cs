namespace AssetTool
{
    [JsonAsset("K2Node_LatentAbilityCall")]
    public class UK2Node_LatentAbilityCall : UK2Node_LatentGameplayTaskCall
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}