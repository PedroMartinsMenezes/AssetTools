namespace AssetTool
{
    [JsonAsset("SmartObjectWorldConditionSchema")]
    public class USmartObjectWorldConditionSchema : UWorldConditionSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}