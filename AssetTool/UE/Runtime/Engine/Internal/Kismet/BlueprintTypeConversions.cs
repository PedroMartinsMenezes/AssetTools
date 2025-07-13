namespace AssetTool
{
    [JsonAsset("BlueprintTypeConversions")]
    public class UBlueprintTypeConversions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}