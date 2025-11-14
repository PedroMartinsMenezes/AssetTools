namespace AssetTool
{
    [JsonAsset("EnhancedInputComponent")]
    public class UEnhancedInputComponent : UInputComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}