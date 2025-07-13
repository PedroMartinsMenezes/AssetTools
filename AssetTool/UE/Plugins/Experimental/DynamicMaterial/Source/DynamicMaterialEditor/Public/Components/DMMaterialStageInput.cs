namespace AssetTool
{
    [JsonAsset("DMMaterialStageInput")]
    public class UDMMaterialStageInput : UDMMaterialStageSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}