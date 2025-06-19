namespace AssetTool
{
    [JsonAsset("AvaGlobalOpacityModifier")]
    public class UAvaGlobalOpacityModifier : UAvaMaterialParameterModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}