namespace AssetTool
{
    [JsonAsset("DMMaterialLayerObject")]
    public class UDMMaterialLayerObject : UDMMaterialComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}