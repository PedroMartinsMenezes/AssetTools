namespace AssetTool
{
    [JsonAsset("AvaTransitionLibrary")]
    public class UAvaTransitionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}