namespace AssetTool
{
    [JsonAsset("TurnBasedBlueprintLibrary")]
    public class UTurnBasedBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}