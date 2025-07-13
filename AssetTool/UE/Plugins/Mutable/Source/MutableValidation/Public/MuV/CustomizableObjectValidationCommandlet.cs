namespace AssetTool
{
    [JsonAsset("CustomizableObjectValidationCommandlet")]
    public class UCustomizableObjectValidationCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}