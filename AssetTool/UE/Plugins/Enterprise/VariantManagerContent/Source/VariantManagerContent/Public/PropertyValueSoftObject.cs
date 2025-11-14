namespace AssetTool
{
    [JsonAsset("PropertyValueSoftObject")]
    public class UPropertyValueSoftObject : UPropertyValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}