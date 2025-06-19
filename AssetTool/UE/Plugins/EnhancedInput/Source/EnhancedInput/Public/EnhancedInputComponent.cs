namespace AssetTool
{
    [JsonAsset("EnhancedInputComponent")]
    public class UEnhancedInputComponent : UInputComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}