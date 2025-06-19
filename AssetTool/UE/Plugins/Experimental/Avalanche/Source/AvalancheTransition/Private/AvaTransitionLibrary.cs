namespace AssetTool
{
    [JsonAsset("AvaTransitionLibrary")]
    public class UAvaTransitionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}