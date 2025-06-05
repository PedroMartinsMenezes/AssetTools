namespace AssetTool
{
    [JsonAsset("AvaTransitionLibrary")]
    public class UAvaTransitionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}