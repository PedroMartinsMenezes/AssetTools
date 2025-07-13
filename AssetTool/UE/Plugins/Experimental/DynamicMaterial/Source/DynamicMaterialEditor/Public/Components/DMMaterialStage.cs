namespace AssetTool
{
    [JsonAsset("DMMaterialStage")]
    public class UDMMaterialStage : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}