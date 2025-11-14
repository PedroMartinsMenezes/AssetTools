namespace AssetTool
{
    [JsonAsset("RigLogicMutableExtension")]
    public class URigLogicMutableExtension : UCustomizableObjectExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}