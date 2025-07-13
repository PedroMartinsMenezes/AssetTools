namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceFactory")]
    public class UCustomizableObjectInstanceFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}