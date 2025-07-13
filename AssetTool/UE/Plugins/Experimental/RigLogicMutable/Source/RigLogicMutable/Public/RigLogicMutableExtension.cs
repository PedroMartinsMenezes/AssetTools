namespace AssetTool
{
    [JsonAsset("RigLogicMutableExtension")]
    public class URigLogicMutableExtension : UCustomizableObjectExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}