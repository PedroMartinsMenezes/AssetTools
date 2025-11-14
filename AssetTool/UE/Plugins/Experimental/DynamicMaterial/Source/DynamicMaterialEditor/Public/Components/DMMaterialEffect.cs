namespace AssetTool
{
    [JsonAsset("DMMaterialEffect")]
    public class UDMMaterialEffect : UDMMaterialComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}