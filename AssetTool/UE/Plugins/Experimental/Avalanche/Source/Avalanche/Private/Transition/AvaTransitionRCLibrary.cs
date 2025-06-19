namespace AssetTool
{
    [JsonAsset("AvaTransitionRCLibrary")]
    public class UAvaTransitionRCLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}