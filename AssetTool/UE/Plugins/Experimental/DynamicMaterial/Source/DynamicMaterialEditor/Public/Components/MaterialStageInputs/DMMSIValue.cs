namespace AssetTool
{
    [JsonAsset("DMMaterialStageInputValue")]
    public class UDMMaterialStageInputValue : UDMMaterialStageInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}