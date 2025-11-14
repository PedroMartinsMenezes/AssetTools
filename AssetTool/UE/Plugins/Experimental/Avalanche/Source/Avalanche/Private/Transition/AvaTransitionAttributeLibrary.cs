namespace AssetTool
{
    [JsonAsset("AvaTransitionAttributeLibrary")]
    public class UAvaTransitionAttributeLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}