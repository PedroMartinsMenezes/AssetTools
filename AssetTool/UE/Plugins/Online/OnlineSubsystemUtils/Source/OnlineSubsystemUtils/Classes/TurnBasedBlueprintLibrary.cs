namespace AssetTool
{
    [JsonAsset("TurnBasedBlueprintLibrary")]
    public class UTurnBasedBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}