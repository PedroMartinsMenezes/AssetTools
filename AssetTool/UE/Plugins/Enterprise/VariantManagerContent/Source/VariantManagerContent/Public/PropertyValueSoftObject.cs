namespace AssetTool
{
    [JsonAsset("PropertyValueSoftObject")]
    public class UPropertyValueSoftObject : UPropertyValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}