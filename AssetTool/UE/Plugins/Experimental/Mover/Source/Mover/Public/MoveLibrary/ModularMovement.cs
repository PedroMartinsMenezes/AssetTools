namespace AssetTool
{
    [JsonAsset("LinearTurnGenerator")]
    public class ULinearTurnGenerator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ExactDampedTurnGenerator")]
    public class UExactDampedTurnGenerator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BlueprintableTurnGenerator")]
    public class UBlueprintableTurnGenerator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}