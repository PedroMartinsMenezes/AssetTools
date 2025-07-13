namespace AssetTool
{
    [JsonAsset("ConcertReplicationBlueprintFunctionLibrary")]
    public class UConcertReplicationBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}