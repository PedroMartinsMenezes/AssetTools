namespace AssetTool
{
    [JsonAsset("DMMaterialStageInput")]
    public class UDMMaterialStageInput : UDMMaterialStageSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}