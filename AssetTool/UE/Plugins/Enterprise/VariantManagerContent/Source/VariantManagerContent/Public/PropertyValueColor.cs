namespace AssetTool
{
    [JsonAsset("PropertyValueColor")]
    public class UPropertyValueColor : UPropertyValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}