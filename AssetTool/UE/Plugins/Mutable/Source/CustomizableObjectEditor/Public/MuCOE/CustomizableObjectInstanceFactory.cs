namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceFactory")]
    public class UCustomizableObjectInstanceFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}