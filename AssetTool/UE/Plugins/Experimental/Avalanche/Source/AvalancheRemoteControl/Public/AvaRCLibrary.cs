namespace AssetTool
{
    [JsonAsset("AvaRCLibrary")]
    public class UAvaRCLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}