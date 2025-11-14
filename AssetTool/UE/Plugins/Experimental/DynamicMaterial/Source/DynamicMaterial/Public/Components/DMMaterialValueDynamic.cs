namespace AssetTool
{
    [JsonAsset("DMMaterialValueDynamic")]
    public class UDMMaterialValueDynamic : UDMMaterialComponentDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}