namespace AssetTool
{
    [JsonAsset("DMMaterialProperty")]
    public class UDMMaterialProperty : UDMMaterialComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}