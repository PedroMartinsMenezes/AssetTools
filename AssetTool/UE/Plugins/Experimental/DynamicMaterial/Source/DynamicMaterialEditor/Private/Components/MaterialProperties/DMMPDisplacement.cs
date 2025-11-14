namespace AssetTool
{
    [JsonAsset("DMMaterialPropertyDisplacement")]
    public class UDMMaterialPropertyDisplacement : UDMMaterialProperty
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}