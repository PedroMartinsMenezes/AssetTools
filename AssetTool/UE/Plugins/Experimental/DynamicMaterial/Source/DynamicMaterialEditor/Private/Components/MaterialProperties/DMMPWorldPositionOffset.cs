namespace AssetTool
{
    [JsonAsset("DMMaterialPropertyWorldPositionOffset")]
    public class UDMMaterialPropertyWorldPositionOffset : UDMMaterialProperty
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}