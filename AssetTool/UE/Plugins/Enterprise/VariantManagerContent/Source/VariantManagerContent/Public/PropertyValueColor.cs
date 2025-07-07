namespace AssetTool
{
    [JsonAsset("PropertyValueColor")]
    public class UPropertyValueColor : UPropertyValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}