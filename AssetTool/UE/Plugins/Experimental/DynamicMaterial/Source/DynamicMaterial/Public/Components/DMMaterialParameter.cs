namespace AssetTool
{
    [JsonAsset("DMMaterialParameter")]
    public class UDMMaterialParameter : UDMMaterialLinkedComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}