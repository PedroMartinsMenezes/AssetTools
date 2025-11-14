namespace AssetTool
{
    [JsonAsset("SmartObjectWorldConditionSchema")]
    public class USmartObjectWorldConditionSchema : UWorldConditionSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}