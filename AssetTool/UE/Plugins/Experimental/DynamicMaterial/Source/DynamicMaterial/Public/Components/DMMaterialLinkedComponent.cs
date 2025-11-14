namespace AssetTool
{
    [JsonAsset("DMMaterialLinkedComponent")]
    public class UDMMaterialLinkedComponent : UDMMaterialComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}