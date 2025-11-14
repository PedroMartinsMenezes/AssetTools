namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputSlot")]
    public class UDMMaterialStageInputSlot : UDMMaterialStageInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}