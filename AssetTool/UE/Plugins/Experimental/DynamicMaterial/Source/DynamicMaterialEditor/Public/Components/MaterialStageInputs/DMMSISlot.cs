namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputSlot")]
    public class UDMMaterialStageInputSlot : UDMMaterialStageInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}