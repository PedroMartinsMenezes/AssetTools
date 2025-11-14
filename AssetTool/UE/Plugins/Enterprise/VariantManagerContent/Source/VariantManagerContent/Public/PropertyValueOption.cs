namespace AssetTool
{
    [JsonAsset("PropertyValueOption")]
    public class UPropertyValueOption : UPropertyValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}