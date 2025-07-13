namespace AssetTool
{
    [JsonAsset("CustomizableObject")]
    public class UCustomizableObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}