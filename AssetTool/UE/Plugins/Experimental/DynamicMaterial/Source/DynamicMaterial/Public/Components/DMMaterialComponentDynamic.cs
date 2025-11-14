namespace AssetTool
{
    [JsonAsset("DMMaterialComponentDynamic")]
    public class UDMMaterialComponentDynamic : UDMMaterialComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}