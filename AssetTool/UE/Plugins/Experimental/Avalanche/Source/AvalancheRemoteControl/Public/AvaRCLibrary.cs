namespace AssetTool
{
    [JsonAsset("AvaRCLibrary")]
    public class UAvaRCLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}