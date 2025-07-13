namespace AssetTool
{
    [JsonAsset("CustomizableInstancePrivate")]
    public class UCustomizableInstancePrivate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}