namespace AssetTool
{
    [JsonAsset("PropertyValueOption")]
    public class UPropertyValueOption : UPropertyValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}