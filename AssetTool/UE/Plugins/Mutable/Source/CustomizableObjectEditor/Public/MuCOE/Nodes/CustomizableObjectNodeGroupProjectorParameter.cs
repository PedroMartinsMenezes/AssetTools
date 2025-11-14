namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeGroupProjectorParameter")]
    public class UCustomizableObjectNodeGroupProjectorParameter : UCustomizableObjectNodeProjectorParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}