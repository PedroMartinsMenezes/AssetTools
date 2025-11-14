namespace AssetTool
{
    [JsonAsset("CustomizableInstancePrivate")]
    public class UCustomizableInstancePrivate : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}