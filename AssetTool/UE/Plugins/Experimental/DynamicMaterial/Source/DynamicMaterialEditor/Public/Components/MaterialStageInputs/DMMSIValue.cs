namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputValue")]
    public class UDMMaterialStageInputValue : UDMMaterialStageInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}