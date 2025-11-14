namespace AssetTool
{
    [JsonAsset("AvaTransitionRCLibrary")]
    public class UAvaTransitionRCLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}