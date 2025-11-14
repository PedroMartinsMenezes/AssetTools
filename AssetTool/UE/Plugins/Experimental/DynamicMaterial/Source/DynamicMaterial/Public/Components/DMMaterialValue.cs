namespace AssetTool
{
    [JsonAsset("DMMaterialValue")]
    public class UDMMaterialValue : UDMMaterialLinkedComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}