namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeGroupProjectorParameter")]
    public class UCustomizableObjectNodeGroupProjectorParameter : UCustomizableObjectNodeProjectorParameter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}