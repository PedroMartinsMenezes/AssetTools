namespace AssetTool
{
    [JsonAsset("AvaTransitionAttributeLibrary")]
    public class UAvaTransitionAttributeLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}