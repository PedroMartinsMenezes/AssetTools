namespace AssetTool
{
    [JsonAsset("EnhancedInputComponent")]
    public class UEnhancedInputComponent : UInputComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}