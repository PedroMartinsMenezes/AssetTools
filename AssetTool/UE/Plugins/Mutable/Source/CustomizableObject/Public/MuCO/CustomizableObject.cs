namespace AssetTool
{
    [JsonAsset("CustomizableObject")]
    public class UCustomizableObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}