namespace AssetTool
{
    [JsonAsset("DMMaterialParameter")]
    public class UDMMaterialParameter : UDMMaterialLinkedComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}